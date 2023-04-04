using Entity;
using Entity.Entity.Account;
using Entity.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Service.Interface;
using System.IdentityModel.Tokens.Jwt;
using System.Text;

namespace WebApiApplication.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    [ApiController]
    public class AccountController : Controller
    {
        public IAccountService _accountService;
        private IConfiguration _config;

        public AccountController(IAccountService accountService, IConfiguration config)
        {
            _accountService = accountService;
            _config = config;
        }
        private string GenerateToken(Account account)
        {
            var securitykey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:key"]));
            var credentials = new SigningCredentials(securitykey, SecurityAlgorithms.HmacSha256);
            var token = new JwtSecurityToken(_config["Jwt:Issuer"], _config["Jwt:Audience"], null,
                 expires: DateTime.Now.AddMinutes(1),
                 signingCredentials: credentials);
            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        [AllowAnonymous]
        [HttpPost("/token")]
        public ResponseAccount? Login(RequestAccount requestAccount)
        {
            var response = _accountService.GetAccount(requestAccount).Result;
            if (response != null) {
                return new ResponseAccount()
                {
                    Avatar = response.Avatar,
                    Locate = response.Locate,
                    UserName = response.Username,
                    UserRole = response.Locate,
                    Token = GenerateToken(response)
                };
            }
            return null;
        }

        [HttpGet("/GetAllAccount")]
        public ResponseBody<List<ResponseAccount>> GetAllAccount()
        {
            List<ResponseAccount> data = _accountService.GetAllAccount().Result;
            try
            {
                return new ResponseBody<List<ResponseAccount>>
                {
                    Status = "",
                    Data = data,
                    Message = ""
                };
            }
            catch (Exception e)
            {
                return new ResponseBody<List<ResponseAccount>>
                {
                    Status = "",
                    Message = e.Message
                };
            }
        }
    }
}
