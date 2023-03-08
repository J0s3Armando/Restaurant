using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Restaurant.API.DTOs;
using Restaurant.API.Utils.Encrypt;
using Restaurant.API.Utils.jwt;
using Restaurant.BLL.Repository;
using Restaurant.Entity;
using System.Security.Cryptography.Xml;

namespace Restaurant.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IConfiguration _configuration;
        public LoginController(IUserService userService, IConfiguration configuration)
        {
            _userService = userService;
            _configuration = configuration;

        }

        [HttpPost]
        public async Task<IActionResult> Login(UserLoginDTO user)
        {
            string usrPasswordEncrypt = EncryptText.EncryptSHA256(user.Password);
            User usr = await _userService.GetByEmailPassword(user.Email, usrPasswordEncrypt);
            if (usr == null)
            {
                return BadRequest();
            }
            string token = new JwtConfiguration(_configuration).GenerateToket(usr);
            return Ok(token);
        }
    }
}
