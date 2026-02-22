using PetFolio.Communication.Enums;

namespace PetFolio.Communication.Responses;

public class ResponseShortPetJson
{
    public int PetId { get; set; }
    public string Name { get; set; } = string.Empty;
    public PetType Type { get; set; }
}
