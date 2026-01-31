using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/users")]
    public class UserController : ControllerBase
    {
        //private readonly IUserService _userService;

        //public UserController(IUserService userService)
        //{
        //    _userService = userService;
        //}

        //[HttpPost("login")]
        //public IActionResult Login(LoginRequest request)
        //{
        //    var result = _userService.Login(request);
        //    return Ok(result);
        //}
    }
}
