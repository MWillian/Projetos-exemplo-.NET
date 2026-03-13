using CashFlow.Communication.Requests;
using CashFlow.Communication.Responses;
using CashFlow.Domain.Entities;

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

        public static ResponseRegisterUserJson ToResponse(User user)
        {
            return new ResponseRegisterUserJson()
            {
                Name = user.Name
            };
        }
    }
}
