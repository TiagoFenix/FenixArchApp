using BasicTestApp.Sales.Services;
using Microsoft.AspNetCore.Mvc;
using System;

namespace BasicTestApp.Api.Controllers
{
    [Route("api/[controller]")]
    public class SalesController : Controller
    {
        private IAccountService _accountService;

        public SalesController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        // GET api/values
        [HttpGet("{userId}")]
        public IActionResult Get(string userId)
        {
            try
            {
                return Ok(_accountService.GetAccount(userId));
            }
            catch (SalesExceptions se)
            {
                throw se;
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
