using System;
using System.Collections.Generic;
using ME.Business.Logic.Abstraction.Interfaces;
using ME.Business.Logic.Abstraction.Models.Messages;

namespace ME.Business.Logic.Abstraction.Scopes.Messages
{
    public interface IMessageScope :        
        IReadable<MessageModel>,
        ICreateable<MessageToCreateModel, MessageModel>,
        IUpdateable<MessageToUpdateModel, MessageModel>,
        IDeleteable
    {
        IEnumerable<MessageModel> GetForChat(Guid chatId);
    }
}
