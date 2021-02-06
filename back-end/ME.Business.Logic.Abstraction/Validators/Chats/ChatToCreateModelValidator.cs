using FluentValidation;
using ME.Business.Logic.Abstraction.Models.Chats;

namespace ME.Business.Logic.Abstraction.Validators.Chats
{
    public class ChatToCreateModelValidator : Base.Validator<ChatToCreateModel>
    {
        public ChatToCreateModelValidator()
        {
            RuleFor(ch => ch.Title).NotNull().NotEmpty().MinimumLength(MinTitleLength).MaximumLength(MaxTitleLength);
            RuleFor(ch => ch.ParticipantIds).NotNull().NotEmpty();
        }
    }
}
