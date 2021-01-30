using FluentValidation.Domain;
using FluentValidation.Results;
using FluentValidation.WebApi.CustomValidations;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FluentValidation.WebApi
{
    [ApiController]
    [Route("api/[controller]")]
    public class TesterController : ControllerBase
    {
        [HttpPost]
        public IActionResult Create()
        {
            var validator = new TesterValidator();
            var validationMessages = new List<string>();
            var tester = new Tester
            {
                FirstName = "",
                Email = "not"
            };
            var validationResult = validator.Validate(tester);
            var response = new ValidationResultModel();
            if (!validationResult.IsValid)
            {
                response.IsValid = false;
                foreach (ValidationFailure failure in validationResult.Errors)
                {
                    validationMessages.Add(failure.ErrorMessage);
                }
                response.ValidationMessages = validationMessages;
            }
            return Ok(response);
        }
    }
}