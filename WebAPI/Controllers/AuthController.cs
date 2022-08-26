using Business.Abstract;
using Entities.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }
        [HttpPost("login")]
        public ActionResult Login(UserForAuthDto userForAuthDto)
        {
            var userToLogin = _authService.Login(userForAuthDto);
            if (userToLogin.Success)
            {
                return Ok(userToLogin.Message);
            }

            return BadRequest(userToLogin.Message);
        }

        [HttpPost("register")]
        public ActionResult Register(UserForAuthDto userForAuthDto)
        {
           
            var registerResult = _authService.Register(userForAuthDto);
            if (registerResult.Success)
            {
                return Ok(registerResult);
            }

            return BadRequest(registerResult.Message);
        }

        [HttpPost("changepassword")]
        public IActionResult ChangePassword(ChangePasswordDto changePasswordDto)
        {
            var result = _authService.ChangePassword(changePasswordDto);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }
        [HttpPost("changeusername")]
        public IActionResult ChangeUserName(ChangeUserNameDto changeUserNameDto)
        {
            var result = _authService.ChangeUserName(changeUserNameDto);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

    }
}
