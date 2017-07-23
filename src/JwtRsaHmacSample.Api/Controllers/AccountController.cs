using JwtRsaHmacSample.Api.Models;
using JwtRsaHmacSample.Api.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JwtRsaHmacSample.Api.Controllers
{
    public class AccountController : Controller
    {
        private readonly IJwtHandler _jwtHandler;

        public AccountController(IJwtHandler jwtHandler)
        {
            _jwtHandler = jwtHandler;
        }

        [HttpGet("me")]
        [Authorize]
        public IActionResult Get()
        {
            return Content($"Hello {User.Identity.Name}");
        } 

        [HttpPost("sign-in")]
        public IActionResult SignIn([FromBody]SignIn request)
        {
            if(string.IsNullOrWhiteSpace(request.Username) || request.Password != "secret")
            {
                return Unauthorized();
            }
            return Json(_jwtHandler.Create(request.Username));
        }
    }
}