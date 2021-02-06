using FluentValidation;
using ME.Business.Logic.Abstraction.Models.Users;

namespace ME.Business.Logic.Abstraction.Validators.Users
{
    public class UserToUpdateModelValidator : Base.Validator<UserToUpdateModel>
    {
        public UserToUpdateModelValidator()
        {
            RuleFor(u => u.Id).NotNull().NotEmpty();
            RuleFor(u => u.Tag).NotNull().NotEmpty().MinimumLength(MinTagLength).MaximumLength(MaxTagLength);
        }
    }
}
