using System.Collections.Generic;

namespace FluentValidation.WebApi.CustomValidations
{
    public class ValidationResultModel
    {
        public ValidationResultModel()
        {
            IsValid = true;
            ValidationMessages = new List<string>();
        }
        public bool IsValid { get; set; }
        public List<string> ValidationMessages { get; set; }
    }
}