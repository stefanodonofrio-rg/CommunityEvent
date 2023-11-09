using FileLocalTypesAsDto.Dto;
using Microsoft.AspNetCore.Mvc;

namespace FileLocalTypesAsDto.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HostController : ControllerBase
    {
        [HttpPost]
        public IActionResult Post(UserDto userDto)
        {
            var user = new User(userDto.Username, userDto.Password);

            // Some work around Identity for Host Entity
            
            return Ok(user);
        }
    }

    file record User( string Username, string Password , string IdentityFor = "Host");
}