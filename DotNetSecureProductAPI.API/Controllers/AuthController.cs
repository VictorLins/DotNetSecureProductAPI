using DotNetSecureProductAPI.Api.Services;
using DotNetSecureProductAPI.Shared;
using Microsoft.AspNetCore.Mvc;

namespace DotNetSecureProductAPI.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private UserService _userService;

        public AuthController(UserService prUserService)
        {
            _userService = prUserService;
        }

        // /api/auth/register
        [HttpPost("Register")]
        public async Task<IActionResult> RegisterAsync([FromBody] RegisterViewModel prModel)
        {
            if (ModelState.IsValid)
            {
                var result = await _userService.RegisterUserAsync(prModel);

                if (result.isSuccess)
                    return Ok(result); // Status Code: 200

                return BadRequest(result);
            }

            return BadRequest("Some properties are not valid"); // Status Code: 400
        }

        // /api/auth/login
        [HttpPost("Login")]
        public async Task<IActionResult> LoginAsync([FromBody] LoginViewModel prModel)
        {
            if (ModelState.IsValid)
            {
                var result = await _userService.LoginUserAsync(prModel);

                if (result.isSuccess)
                    return Ok(result); // Status Code: 200

                return BadRequest(result);
            }

            return BadRequest("Some properties are not valid"); // Status Code: 400
        }
    }
}