using FluentValidation.Domain;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace FluentValidation.WebApi
{
    [ApiController]
    [Route("api/[controller]")]
    public class DevelopersController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> Create(Developer developer)
        {
            return Ok();
        }
    }
}