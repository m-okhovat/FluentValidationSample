using FluentValidation.Domain;
using System;
using System.Linq;

namespace FluentValidation.WebApi.CustomValidations
{
    public class DeveloperValidation : AbstractValidator<Developer>
    {
        public DeveloperValidation()
        {
            RuleFor(p => p.Email)
                .EmailAddress();

            RuleFor(a => a.FirstName)
                .Cascade(CascadeMode.Stop)
                .NotEmpty()
                .WithMessage("{PropertyName} should not be empty")
                .Length(10, 20)
                .Must(IsValidName).WithMessage("{PropertyName} should be all letters!");
        }

        private bool IsValidName(string name)
        {
            return name.All(Char.IsLetter);
        }
    }
}