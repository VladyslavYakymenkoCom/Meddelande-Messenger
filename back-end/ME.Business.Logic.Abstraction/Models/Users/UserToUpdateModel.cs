using System;
using FluentValidation;
using ME.Business.Logic.Abstraction.Validators.Users;

namespace ME.Business.Logic.Abstraction.Models.Users
{
    public class UserToUpdateModel
    {
        public Guid Id { get; set; }  

        public string Tag { get; set; }

        public void ValidateAndThrow()
        {
            new UserToUpdateModelValidator().ValidateAndThrow(this);
        }
    }
}
