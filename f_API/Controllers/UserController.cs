using f_API.Communication.Request;
using f_API.Communication.Responses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace f_API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
    [HttpGet]
    [Route("{id}")]
    [ProducesResponseType(typeof(User), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(User), StatusCodes.Status400BadRequest)]
    public IActionResult GetById(int id)
    {
        var response = new User
        {
            Id = 1,
            Age = 23,
            Name = "Matheus"
        };
        return Ok(response);
    }

    [HttpPost]
    [ProducesResponseType(typeof(ResponseRegisterUserJson), StatusCodes.Status201Created)]
    public IActionResult CreateUser([FromBody]RequestRegisterUserJson user)
    {
        var response = new ResponseRegisterUserJson
        {
            Age = 23,
            Name = "Matt"
        };
        return Created(string.Empty, response);
    }

    [HttpPut]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult Update([FromRoute] int id,[FromBody] RequestUpdateUserJon request)
    {
        return NoContent();
    }

    [HttpDelete]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult Delete([FromRoute]int id)
    {
        return NoContent();
    }

    [HttpGet]
    [ProducesResponseType(typeof(List <User>), StatusCodes.Status200OK)]
    public IActionResult GetAll()
    {
        var response = new List<User>
        {
            new User {Id = 1, Age = 20, Name = "Matheus"},
            new User {Id = 2, Age = 24, Name = "Willian"}
        };
        return Ok(response);
    }

    [HttpPut("change-password")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult ChangePassword([FromBody] RequestChangePassWordJson request)
    {
        return NoContent();
    }
}
