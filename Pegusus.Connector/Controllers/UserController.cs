namespace Pegusus.Connector.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;
    using Pegusus.Connector.Logger;
    using System.Threading.Tasks;

    [ApiController]
    [Route("Api/[controller]")]
    public class UserController : Controller
    {
        private readonly ILoggerManager _iloggerManager;

        public UserController(ILoggerManager iloggerManager)
        {
            _iloggerManager = iloggerManager;
        }
 
        [HttpGet]
        [Route("CustomerLoging")]
        public async Task<IActionResult> CustomerLoging()
        {
            _iloggerManager.LogInfo("start to loging to Customer");
            return Ok();


        } 
 
    }
}
