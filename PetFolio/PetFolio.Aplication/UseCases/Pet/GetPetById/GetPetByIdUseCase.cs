using PetFolio.Communication.Enums;
using PetFolio.Communication.Responses;

namespace PetFolio.Aplication.UseCases.Pet.GetPetById;

public class GetPetByIdUseCase
{
    public ResponsePetJson Execute()
    {
        return new ResponsePetJson
        {
            Id = 1,
            Birthday = DateTime.Now,
            Name = "Test",
            Type = PetType.Cat
        };
    }
}
