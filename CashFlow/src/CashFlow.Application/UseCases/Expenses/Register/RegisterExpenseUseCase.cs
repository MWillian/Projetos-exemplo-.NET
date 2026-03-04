using CashFlow.Application.Mappers;
using CashFlow.Communication.Requests;
using CashFlow.Communication.Responses;
using CashFlow.Domain.Entities;
using CashFlow.Domain.Repositories.Expenses;
using CashFlow.Exception.ExceptionBase;

namespace CashFlow.Application.UseCases.Expenses.Register;

public class RegisterExpenseUseCase : IRegisterExpenseUseCase
{
    private readonly IExpensesRepository _repository;
    private readonly IUnitOfWork _unitOfWork;

    public RegisterExpenseUseCase(IExpensesRepository repository, IUnitOfWork unitOfWork)
    {
        _repository = repository;
        _unitOfWork = unitOfWork;
    }
    public async Task<ResponseRegisterExpenseJson?> Execute(RequestExpenseJson request)
    {
        ValidadeRequest(request);
        var expenseEntity = ExpenseMapper.ToEntity(request);
        await _repository.AddExpense(expenseEntity);
        await _unitOfWork.Commit();
        return ExpenseMapper.ToResponse(expenseEntity);
    }

    private void ValidadeRequest(RequestExpenseJson request)
    {
        var validator = new RequestExpenseValidator();
        var result = validator.Validate(request);
        if (!result.IsValid)
        {
            var errorsList = result.Errors.Select(x => x.ErrorMessage).ToList();
            throw new ErrorOnValidationException(errorsList);
        }
    }
}
