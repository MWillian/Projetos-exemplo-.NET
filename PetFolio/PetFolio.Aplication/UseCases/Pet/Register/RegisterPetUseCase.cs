using PetFolio.Communication.Requests;
using PetFolio.Communication.Responses;

namespace PetFolio.Aplication.UseCases.Pet.Register;

public class RegisterPetUseCase
{
    public ResponseRegisterPetJson Execute(RequestPetJson request)
    {
        return new ResponseRegisterPetJson
        {
            id = 7,
            Name = request.Name
        };
    }
}
