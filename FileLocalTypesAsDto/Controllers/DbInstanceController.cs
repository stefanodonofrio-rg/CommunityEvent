using FileLocalTypesAsDto.Dto;
using Microsoft.AspNetCore.Mvc;

namespace FileLocalTypesAsDto.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class DbInstanceController : ControllerBase
    {

        [HttpPost]
        public IActionResult Post(UserDto userDto)
        {
            var user = new User(userDto.Username, userDto.Password);

            // Some work around Identity for DbInstance Entity
            
            return Ok(user);
        }
    }

    file record User(string Username, string Password, string IdentityFor = "DbInstance");
}
