using FluentValidation;
using ME.Business.Logic.Abstraction.Models.Chats;

namespace ME.Business.Logic.Abstraction.Validators.Chats
{
    public class ChatToUpdateModelValidator : Base.Validator<ChatToUpdateModel>
    {
        public ChatToUpdateModelValidator()
        {
            RuleFor(m => m.Id).NotNull().NotEmpty();
            RuleFor(m => m.Title).NotNull().NotEmpty().MinimumLength(MinTitleLength).MaximumLength(MaxTitleLength);
        }
    }
}
