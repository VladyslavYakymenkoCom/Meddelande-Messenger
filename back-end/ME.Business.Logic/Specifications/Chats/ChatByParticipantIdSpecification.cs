using EntityFrameworkCore.CommonTools;
using ME.Data.Models.Chats;
using System;
using System.Linq;

namespace ME.Business.Logic.Specifications.Chats
{
    public class ChatByParticipantIdSpecification : Specification<Chat>
    {
        public ChatByParticipantIdSpecification(Guid id): base(ch => ch.Participants.Any(p => p.UserId == id))
        {

        }
    }
}
