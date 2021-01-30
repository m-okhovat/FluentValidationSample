using FluentValidation.Domain;

namespace FluentValidation.WebApi.CustomValidations
{
    public class TesterValidator : AbstractValidator<Tester>
    {
        public TesterValidator()
        {
            RuleFor(p => p.FirstName)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("{PropertyName} should be not empty. NEVER!")
                .Length(2, 25);
        }
    }
}