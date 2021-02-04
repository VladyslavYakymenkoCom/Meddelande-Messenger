using ME.Data.Access.Abstractions.Repositories;
using ME.Data.Access.Base;
using ME.Data.Access.Context;
using ME.Data.Models.Messages;
using System;
using System.Collections.Generic;

namespace ME.Data.Access.Repositories
{
    public class MessageRepository : CrudRepository<Message>, IMessageRepository
    {
        public MessageRepository(MeddelandeContext context): base(context)
        {

        }

        public override void Remove(Message entity)
        {
            entity.IsDeactivated = true;
        }
    }
}
