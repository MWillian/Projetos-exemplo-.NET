using Microsoft.AspNetCore.Mvc;
using PetFolio.Aplication.UseCases.Pet.DeletePetById;
using PetFolio.Aplication.UseCases.Pet.GetAll;
using PetFolio.Aplication.UseCases.Pet.GetPetById;
using PetFolio.Aplication.UseCases.Pet.Register;
using PetFolio.Aplication.UseCases.Pet.Update;
using PetFolio.Communication.Requests;
using PetFolio.Communication.Responses;

namespace PetFolio.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class PetController : ControllerBase
{
    [HttpPost]
    [ProducesResponseType(typeof(RequestPetJson), StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status400BadRequest)]
    public IActionResult Register([FromBody] RequestPetJson request)
    {
        var response = new RegisterPetUseCase().Execute(request);
        return Created(string.Empty, response);
    }

    [HttpPut]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status400BadRequest)]
    public IActionResult Update([FromRoute] int id, [FromBody] RequestPetJson request)
    {
        var useCase = new UpdatePetUseCase();
        useCase.Execute(request, id);
        return NoContent();
    }
    [HttpGet]
    [ProducesResponseType(typeof(ResponseAllPetJson), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult GetAllPets()
    {
        var useCase = new GetAllPetsUseCase();
        var response = useCase.Execute();
        if (response.Pets.Count == 0)
        {
            return NoContent();
        }
        return Ok();
    }
    [HttpGet]
    [Route("{id}")]
    [ProducesResponseType(typeof(ResponsePetJson), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status404NotFound)]
    public IActionResult GetPetById([FromRoute] int id)
    {
        var useCase = new GetPetByIdUseCase();
        var response = useCase.Execute();
        if (response.Id == id) return Ok(response);
        return NoContent();
    }

    [HttpDelete]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status404NotFound)]
    public IActionResult DeletePetById([FromRoute] int id)
    {
        var useCase = new DeletePetByIdUseCase();
        return NoContent();
    }
}
