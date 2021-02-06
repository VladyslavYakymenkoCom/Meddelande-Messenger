using FluentValidation;
using ME.Business.Logic.Abstraction.Models.Users;

namespace ME.Business.Logic.Abstraction.Validators.Users
{
    public class UserToCreateModelValidator : Base.Validator<UserToCreateModel>
    {
        public UserToCreateModelValidator()
        {
            RuleFor(u => u.Tag).NotNull().NotEmpty().MinimumLength(MinTagLength).MaximumLength(MaxTagLength);
            RuleFor(u => u.Password).NotNull().NotEmpty().MinimumLength(MinPasswordLength).MaximumLength(MaxPasswordLength);
        }
    }
}
