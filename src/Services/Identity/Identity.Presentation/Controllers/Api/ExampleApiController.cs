using Microsoft.AspNetCore.Mvc;

namespace Identity.Presentation.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExampleApiController (IDomainService): ControllerBase
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
