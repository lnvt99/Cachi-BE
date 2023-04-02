using Microsoft.AspNetCore.Mvc;
using Service.Interface;

namespace WebApiApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountTypeController : Controller
    {
        public IAccountTypeService _accountTypeService;
        public AccountTypeController(IAccountTypeService accountTypeService)
        {
            _accountTypeService = accountTypeService;
        }
    }
}
