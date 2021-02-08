using System;
using System.Collections.Generic;
using ME.Business.Logic.Abstraction.Interfaces;
using ME.Business.Logic.Abstraction.Models.Users;

namespace ME.Business.Logic.Abstraction.Scopes.Users
{
    public interface IUserScope :
        IReadable<UserModel>,
        ICreateable<UserToCreateModel, UserModel>,
        IUpdateable<UserToUpdateModel, UserModel>,
        IDeleteable
    {
    }
}
