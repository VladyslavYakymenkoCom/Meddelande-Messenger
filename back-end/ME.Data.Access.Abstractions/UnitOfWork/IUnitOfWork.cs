using ME.Data.Access.Abstractions.Repositories;
using System;
using System.Threading.Tasks;

namespace ME.Data.Access.Abstractions.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        // TODO: Singletons;
        #region Users
        IUserRepository User { get; }
        #endregion

        #region Messages
        IMessageRepository Message { get; }
        #endregion

        #region Chats
        IChatRepository Chat { get; }
        #endregion

        void Commit();
        Task CommitAsync();

        // TODO: Transaction;  
        // TODO: Rollback; 
    }
}
