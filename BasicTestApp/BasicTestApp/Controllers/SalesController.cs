using Microsoft.AspNetCore.Mvc;

namespace BasicTestApp.Api.Controllers
{
    [Route("api/[controller]")]
    public class SalesController : Controller
    {
        // GET api/values
        [HttpGet]
        public string Get()
        {
            return "Hi";
        }
    }
}
