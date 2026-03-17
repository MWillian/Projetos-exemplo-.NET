using CashFlow.Communication.Requests;
using CashFlow.Communication.Responses;
using CashFlow.Domain.Entities;
using CashFlow.Domain.Secutiry.Tokens;
using CashFlow.Domain.User;

namespace CashFlow.Application.Mappers
{
    
    public static class UserMapper
    {
        public static User ToEntity(RequestRegisterUserJson request)
        {
            return new User()
            {
                Email = request.Email,
                Name = request.Name,
                UserIdentifier = Guid.NewGuid(),
            };
        }

        public static ResponseRegisterUserJson ToResponse(User user, IAcessTokenGenerator tokenGenerator)
        {
            return new ResponseRegisterUserJson()
            {
                Name = user.Name,
                Token = tokenGenerator.Generate(user)
            };
        }
    }
}
