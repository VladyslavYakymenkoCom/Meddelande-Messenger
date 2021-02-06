using FluentValidation;
using ME.Business.Logic.Abstraction.Models.Messages;

namespace ME.Business.Logic.Abstraction.Validators.Messages
{
    public class MessageToUpdateModelValidator : Base.Validator<MessageToUpdateModel>
    {
        public MessageToUpdateModelValidator()
        {
            RuleFor(m => m.Id).NotNull().NotEmpty();
            RuleFor(m => m.Body).NotNull().NotEmpty().MinimumLength(MinBodyLength).MaximumLength(MaxBodyLength);
        }
    }
}
