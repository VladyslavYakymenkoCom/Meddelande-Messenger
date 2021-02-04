using ME.Data.Access.Abstractions.Repositories;
using ME.Data.Access.Abstractions.UnitOfWork;
using ME.Data.Access.Context;
using System;
using System.Threading.Tasks;

namespace ME.Data.Access.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private bool disposed = false;
        private MeddelandeContext _context;

        public IUserRepository UserRepository { get; set; }
        public IMessageRepository MessageRepository { get; set; }
        public IChatRepository ChatRepository { get; set; }

        // TODO: Create factory;
        public UnitOfWork(MeddelandeContext context)
        {
            _context = context;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
        }

        #region Dispose pattern
        public virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                    _context.Dispose();

                disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);

            GC.SuppressFinalize(this);
        }
        #endregion
    }
}
