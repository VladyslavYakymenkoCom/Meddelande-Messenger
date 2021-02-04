using ME.Data.Access.Abstractions.Interfaces;
using ME.Data.Models.Chats;
using System;
using System.Threading.Tasks;

namespace ME.Data.Access.Abstractions.Repositories
{
    public interface IChatRepository :
        ICreateable<Chat>,
        ISearchable<Chat>,
        IFetchable<Chat>,
        IDeletable<Chat>
    {
        Task<UserChat> AddParticipantAsync(Guid participantId, Guid chatId);
        UserChat AddParticipant(Guid participantId, Guid chatId);
    }
}
