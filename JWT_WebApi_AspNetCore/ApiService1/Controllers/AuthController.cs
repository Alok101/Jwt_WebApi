using ApiService1.Models;
using Microsoft.AspNetCore.Mvc;
using OuthServer;

namespace ApiService1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        [HttpPost,Route("Login")]
        public IActionResult Login([FromBody]LoginModel user)
        {
            if (user == null) return BadRequest("Invalid Client Request");
            if(user.UserName=="alok" && user.Password == "alok@123")
            {
                return Ok(new { Token =GenerateToken.GenerateJwtToken(user.UserName) });
            }
            else
            {
                return Unauthorized();
            }
        }
    }
}