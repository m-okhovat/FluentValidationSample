using System.Threading.Tasks;
using FluentValidation.Domain;
using Microsoft.AspNetCore.Mvc;

namespace FluentValidation.WebApi.Controllers
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