using ME.Data.Access.Abstractions.Interfaces;
using ME.Data.Models.Messages;

namespace ME.Data.Access.Abstractions.Repositories
{
    public interface IMessageRepository :
        ICreateable<Message>,
        ISearchable<Message>,
        IFetchable<Message>,
        IDeletable<Message>
    {
    }
}
