using ME.Data.Access.Abstractions.Repositories;
using ME.Data.Access.Base;
using ME.Data.Access.Context;
using ME.Data.Models.Users;
using System;
using System.Collections.Generic;

namespace ME.Data.Access.Repositories
{
    public class UserRepository : CrudRepository<User>, IUserRepository
    {
        public UserRepository(MeddelandeContext context) : base(context)
        {

        }

        public override void Remove(User entity)
        {
            entity.IsDeactivated = true;
        }
    }
}
