using ME.Data.Access.Abstractions.Repositories;
using ME.Data.Access.Base;
using ME.Data.Access.Context;
using ME.Data.Models.Chats;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ME.Data.Access.Repositories
{
    public class ChatRepository : CrudRepository<Chat>, IChatRepository
    {
        public ChatRepository(MeddelandeContext context) : base(context)
        {

        }

        public UserChat AddParticipant(Guid participantId, Guid chatId)
        {
            return Context.UserChats.Add(new UserChat
            {
                UserId = participantId,
                ChatId = chatId
            }).Entity;
        }

        public async Task<UserChat> AddParticipantAsync(Guid participantId, Guid chatId)
        {
            return (await Context.UserChats.AddAsync(new UserChat
            {
                UserId = participantId,
                ChatId = chatId
            })).Entity;
        }

        public override void Remove(Chat entity)
        {
            entity.IsDeactivated = true;
        }
    }
}
