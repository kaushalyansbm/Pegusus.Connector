namespace Pegusus.Connector.Controllers
{
    using Logger;
    using Microsoft.AspNetCore.Mvc;
    using Pegusus.Data.Model;
    using Pegusus.Services.Interfaces;
    using Services.ViewModels;
    using System.Threading.Tasks;
    [ApiController]
    [Route("Api/[controller]")]
    public class UserController : Controller
    {
        private readonly ILoggerManager _iloggerManager;
        private readonly IUserService _iUserService;

        public UserController(ILoggerManager iloggerManager, IUserService iUserService)
        {
            _iUserService = iUserService;
            _iloggerManager = iloggerManager;
        }

        [HttpPost]
        [Route("CustomerLoging")]
        public async Task<IActionResult> CustomerLoging(UserViewModels userViewModel)
        {
            User user = new User();
            user.Email = userViewModel.Email;
            _iUserService.GetValidUser(user);
            _iloggerManager.LogInfo("start to loging to Customer");
            return Ok();
        }
        [HttpGet]
        [Route("CustomersLoging")]
        public async Task<IActionResult> CustomerwLoging()
        {
  
            return Ok("sas");
        }

    }
}
