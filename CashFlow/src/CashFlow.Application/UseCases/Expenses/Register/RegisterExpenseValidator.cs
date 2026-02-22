using CashFlow.Communication.Requests;
using CashFlow.Exception;
using FluentValidation;

namespace CashFlow.Application.UseCases.Expenses.Register;

public class RegisterExpenseValidator : AbstractValidator<RequestRegisterExpenseJson>
{
    public RegisterExpenseValidator()
    {
        RuleFor(expense => expense.Ammount).NotEmpty().GreaterThan(0).WithMessage(ResourceErrorMessages.THE_AMMOUNT_CANNOT_BE_NEGATIVE);
        RuleFor(expense => expense.Title).NotEmpty().WithMessage(ResourceErrorMessages.TITLE_IS_REQUIRED);
        RuleFor(expense => expense.Date).LessThanOrEqualTo(DateTime.UtcNow).WithMessage(ResourceErrorMessages.EXPENSE_DATE_CANNOT_BE_FUTURE);
        RuleFor(expense => expense.Payment).IsInEnum().WithMessage(ResourceErrorMessages.VALID_PAYMENT);
    }
}
