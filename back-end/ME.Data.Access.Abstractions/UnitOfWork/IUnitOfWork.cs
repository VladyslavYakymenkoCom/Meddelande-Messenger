using ME.Data.Access.Abstractions.Repositories;
using System;
using System.Threading.Tasks;

namespace ME.Data.Access.Abstractions.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        // TODO: Singletons;
        #region Users
        IUserRepository UserRepository { get; set; }
        #endregion

        #region Messages
        IMessageRepository MessageRepository { get; set; }
        #endregion

        #region Chats
        IChatRepository ChatRepository { get; set; }
        #endregion

        void Commit();
        Task CommitAsync();

        // TODO: Transaction;  
        // TODO: Rollback; 
    }
}
