using EntityFrameworkCore.CommonTools;
using ME.Data.Models.Messages;
using System;

namespace ME.Business.Logic.Specifications.Messages
{
    public class MessageByChatIdSpecification : Specification<Message>
    {
        public MessageByChatIdSpecification(Guid id) : base(m => m.Id == id)
        {

        }
    }
}
