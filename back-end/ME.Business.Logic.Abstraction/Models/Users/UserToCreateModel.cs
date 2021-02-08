using FluentValidation;
using ME.Business.Logic.Abstraction.Validators.Users;

namespace ME.Business.Logic.Abstraction.Models.Users
{
    public class UserToCreateModel
    {
        public string Tag { get; set; }
        public string Password { get; set; }

        public void ValidateAndThrow()
        {
             new UserToCreateModelValidator().ValidateAndThrow(this);
        }
    }
}
