using Microsoft.AspNetCore.Mvc;

namespace ME.Api.Controllers
{
    [ApiController]
    [Route("state-indicator")]
    public class StateIndicatorController : ControllerBase
    {
        public StateIndicatorController()
        {

        }

        [HttpGet]
        public IActionResult State()
        {
            var response = "state: OK";

            return new JsonResult(response);
        }
    }
}
