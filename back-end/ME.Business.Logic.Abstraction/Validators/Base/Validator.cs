using FluentValidation;

namespace ME.Business.Logic.Abstraction.Validators.Base
{
    public abstract class Validator<TModel> : AbstractValidator<TModel>
    {
        protected int MaxTagLength = 100;
        protected int MaxTitleLength = 255;
        protected int MaxBodyLength = 1024;
        protected int MaxPasswordLength = 1024;

        protected int MinTagLength = 100;
        protected int MinTitleLength = 1;
        protected int MinBodyLength = 1;
        protected int MinPasswordLength = 6;
    }
}
