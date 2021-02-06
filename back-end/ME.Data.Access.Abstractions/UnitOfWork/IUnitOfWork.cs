using ME.Data.Access.Abstractions.Repositories;
using System;
using System.Threading.Tasks;

namespace ME.Data.Access.Abstractions.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        // TODO: Singletons;
        #region Users
        IUserRepository UserRepository { get; }
        #endregion

        #region Messages
        IMessageRepository MessageRepository { get; }
        #endregion

        #region Chats
        IChatRepository ChatRepository { get; }
        #endregion

        void Commit();
        Task CommitAsync();

        // TODO: Transaction;  
        // TODO: Rollback; 
    }
}
