using _3oChallengeApp.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace _3oChallengeApp.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    [ApiController]
    public class UserController : ControllerBase
    {

        public UserController()
        {
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("authorize")]
        public IActionResult AuthorizeUser([FromQuery(Name = "code")] string code)
        {
            return Ok(new { authorization_code = code }); ;
        }
    }
}
