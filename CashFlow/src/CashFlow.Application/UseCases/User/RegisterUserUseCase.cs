using CashFlow.Application.Mappers;
using CashFlow.Communication.Requests;
using CashFlow.Communication.Responses;
using CashFlow.Domain.Repositories.Expenses;
using CashFlow.Domain.Secutiry.Cryptography;
using CashFlow.Domain.Secutiry.Tokens;
using CashFlow.Domain.User;
using CashFlow.Exception;
using CashFlow.Exception.ExceptionBase;

namespace CashFlow.Application.UseCases.User
{
    public class RegisterUserUseCase : IRegisterUserUseCase
    {
        private readonly IUserRepository _repository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IPasswordEncripter _encrypter;
        IAcessTokenGenerator _acessTokenGenerator;
        public RegisterUserUseCase(IUserRepository repository, IUnitOfWork unitOfWork, IPasswordEncripter encrypter, IAcessTokenGenerator acessTokenGenerator)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
            _encrypter = encrypter;
            _acessTokenGenerator = acessTokenGenerator;
        }
        public async Task<ResponseRegisterUserJson> Execute(RequestRegisterUserJson request)
        {
            await ValidadeRequest(request);
            var userEntity = UserMapper.ToEntity(request);
            userEntity.Password = _encrypter.Encrypt(request.Password);
            await _repository.Add(userEntity);
            await _unitOfWork.Commit();
            return UserMapper.ToResponse(userEntity, _acessTokenGenerator);
        }
        private async Task ValidadeRequest(RequestRegisterUserJson request)
        {
            var validator = new RequestUserValidator();
            var result = validator.Validate(request);
            var emailExist = await _repository.ExistActiveUserWithEmail(request.Email);

            if (emailExist)
            {
                result.Errors.Add(new FluentValidation.Results.ValidationFailure(string.Empty, ResourceErrorMessages.EMAIL_ALREADY_REGISTRED));
            }

            if (!result.IsValid)
            {
                var errorsList = result.Errors.Select(x => x.ErrorMessage).ToList();
                throw new ErrorOnValidationException(errorsList);
            }
        }
    }
}
