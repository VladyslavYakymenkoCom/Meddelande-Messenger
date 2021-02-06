using FluentValidation;

namespace ME.Business.Logic.Abstraction.Validators.Base
{
    public abstract class Validator<TModel> : AbstractValidator<TModel>
    {
        protected static int MaxTagLength = 100;
        protected static int MaxTitleLength = 255;
        protected static int MaxBodyLength = 1024;
        protected static int MaxPasswordLength = 1024;

        protected static int MinTagLength = 100;
        protected static int MinTitleLength = 1;
        protected static int MinBodyLength = 1;
        protected static int MinPasswordLength = 6;

        // ALT: Extestion method on IRuleBuilder, reason - BLSP.
        protected string PasswordRegex = string.Format(@"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{{0},{1}}$", MinPasswordLength, MaxPasswordLength);
    }
}
