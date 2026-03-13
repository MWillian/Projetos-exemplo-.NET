using CashFlow.Communication.Requests;
using CashFlow.Exception;
using FluentValidation;

namespace CashFlow.Application.UseCases.User
{
    public class RequestUserValidator : AbstractValidator<RequestRegisterUserJson>
    {
        public RequestUserValidator()
        {
            RuleFor(user => user.Name).NotEmpty().WithMessage(ResourceErrorMessages.USER_NAME_IS_REQUIRED);
            RuleFor(user => user.Email).NotEmpty().EmailAddress().WithMessage(ResourceErrorMessages.INVALID_EMAIL);
            RuleFor(user => user.Password).SetValidator(new UserPasswordValidator<RequestRegisterUserJson>());
        }
    }
}
