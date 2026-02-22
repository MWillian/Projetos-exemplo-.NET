using PetFolio.Communication.Enums;
using PetFolio.Communication.Responses;

namespace PetFolio.Aplication.UseCases.Pet.GetAll;

public class GetAllPetsUseCase
{
    public ResponseAllPetJson Execute()
    {
        return new ResponseAllPetJson
        {
            //Pets = new List<ResponseShortPetJson>
            //{
            //    new ResponseShortPetJson
            //    {
            //        PetId = 1,
            //        Name = "Matheus",
            //        Type = PetType.Cat
            //    }
            //}
        };
    }
}
