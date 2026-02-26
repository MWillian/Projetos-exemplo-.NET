using CashFlow.Communication.Requests;
using CashFlow.Communication.Responses;
using CashFlow.Domain.Entities;
using CashFlow.Exception.ExceptionBase;

namespace CashFlow.Application.UseCases.Expenses.Register;

public class RegisterExpenseUseCase
{
    public ResponseRegisterExpenseJson Execute(RequestRegisterExpenseJson request)
    {
        if (ValidadeRequest(request))
        {
            var expenseEntity = new Expense()
            {
                Amount = request.Ammount,
                Title = request.Title,
                Description = request.Description,
                Date = request.Date,
                Payment = (Domain.Enums.PaymentType)request.Payment
            };
        }
        return new ResponseRegisterExpenseJson();
    }

    private bool ValidadeRequest(RequestRegisterExpenseJson request)
    {
        var validator = new RegisterExpenseValidator();
        var result = validator.Validate(request);
        if (!result.IsValid)
        {
            var errorsList = result.Errors.Select(x => x.ErrorMessage).ToList();
            throw new ErrorOnValidationException(errorsList);
        }
        return true;
    }
}
