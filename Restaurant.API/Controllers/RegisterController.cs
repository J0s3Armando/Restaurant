using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Restaurant.API.DTOs;
using Restaurant.BLL.Repository;
using Restaurant.Entity;

namespace Restaurant.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegisterController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;
        public RegisterController(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }
        [HttpPost]
        [Route("RegisterCustomer")]
        public async Task<IActionResult> RegisterCustomer(UserRegisterDTO user)
        {
            if (user.Idrol>1)
            {
                return BadRequest(new { message = "Ocurrió un error al registrarse, por favor intente nuevamente." });
            }
            User newUser = await _userService.Insert(_mapper.Map<User>(user));
            if (newUser == null)
            {
                return BadRequest(new { message = "Ocurrió un error al registrarse, por favor intente nuevamente." }) ;
            }
            return Ok(new{data= user, message="Registrado correctamente." });
        }


        [HttpPost]
        [Route("RegisterEmployee")]
        [Authorize(Roles = "3")]
        public async Task<IActionResult> RegisterEmploye(UserRegisterDTO user)
        {
            User newUser = await _userService.Insert(_mapper.Map<User>(user));
            if (newUser == null)
            {
                return BadRequest(new { message = "Ocurrió un error al registrarse, por favor intente nuevamente." });
            }
            return Ok(new { data = newUser, message = "Registrado correctamente." });
        }
    }
}
