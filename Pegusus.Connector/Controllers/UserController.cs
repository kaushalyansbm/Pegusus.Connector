namespace Pegusus.Connector.Controllers
{
    using Logger;
    using Microsoft.AspNetCore.Mvc;
    using Services.ViewModels;
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
        public async Task<IActionResult> CustomerLoging(UserViewModels userViewModel)
        {
            _iloggerManager.LogInfo("start to loging to Customer");
            return Ok();
        }

    }
}
