using ME.Data.Access.Abstractions.Interfaces;
using ME.Data.Models.Users;

namespace ME.Data.Access.Abstractions.Repositories
{
    public interface IUserRepository :
        ICreateable<User>,
        ISearchable<User>,
        IFetchable<User>,
        IDeletable<User>
    {
    }
}
