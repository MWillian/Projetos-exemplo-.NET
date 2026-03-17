using CashFlow.Communication.Requests;
using CashFlow.Communication.Responses;
using CashFlow.Domain.Secutiry.Cryptography;
using CashFlow.Domain.Secutiry.Tokens;
using CashFlow.Domain.User;
using CashFlow.Exception.ExceptionBase;

namespace CashFlow.Application.UseCases.Login
{
    public class DoLoginUseCase : IDoLoginUseCase
    {
        private readonly IPasswordEncripter _passwordEncripter;
        private readonly IAcessTokenGenerator _acessTokenGenerator;
        private readonly IUserRepository _userRepository;
        public DoLoginUseCase(IPasswordEncripter passwordEncripter, IAcessTokenGenerator acessTokenGenerator, IUserRepository userRepository)
        {
            _passwordEncripter = passwordEncripter;
            _userRepository = userRepository;
            _acessTokenGenerator = acessTokenGenerator;
        }

        public async Task<ResponseRegisterUserJson> Execute(RequestLoginJson request)
        {
            var user = await _userRepository.GetUserByEmail(request.Email);
            if (user is null)
            {
                throw new InvalidLoginException();
            }
            var passwordMatch = _passwordEncripter.Verify(request.Password, user.Password);
            if (passwordMatch is false)
            {
                throw new InvalidLoginException();
            }
            return new ResponseRegisterUserJson
            {
                Name = user.Name,
                Token = _acessTokenGenerator.Generate(user)
            };
        }
    }
}
