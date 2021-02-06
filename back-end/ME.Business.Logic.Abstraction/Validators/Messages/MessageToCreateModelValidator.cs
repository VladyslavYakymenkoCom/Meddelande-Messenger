using FluentValidation;
using ME.Business.Logic.Abstraction.Models.Messages;

namespace ME.Business.Logic.Abstraction.Validators.Messages
{
    public class MessageToCreateModelValidator : Base.Validator<MessageToCreateModel>
    {
        public MessageToCreateModelValidator()
        {
            RuleFor(m => m.AuthorId).NotNull().NotEmpty();
            RuleFor(m => m.Body).NotNull().NotEmpty().MinimumLength(MinBodyLength).MaximumLength(MaxBodyLength);
        }
    }
}
