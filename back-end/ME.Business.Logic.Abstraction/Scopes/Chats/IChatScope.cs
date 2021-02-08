using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ME.Business.Logic.Abstraction.Interfaces;
using ME.Business.Logic.Abstraction.Models.Chats;

namespace ME.Business.Logic.Abstraction.Scopes.Chats
{
    public interface IChatScope :
        IReadable<ChatModel>,
        ICreateable<ChatToCreateModel, ChatModel>,
        IUpdateable<ChatToUpdateModel, ChatModel>,
        IDeleteable
    {
        Task<IEnumerable<ChatListItemModel>> GetForUser(Guid userId);
    }
}
