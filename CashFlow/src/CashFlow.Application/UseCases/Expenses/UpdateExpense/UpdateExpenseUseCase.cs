using CashFlow.Application.Mappers;
using CashFlow.Application.UseCases.Expenses.Register;
using CashFlow.Communication.Requests;
using CashFlow.Domain.Entities;
using CashFlow.Domain.Repositories.Expenses;
using CashFlow.Exception;
using CashFlow.Exception.ExceptionBase;

namespace CashFlow.Application.UseCases.Expenses.UpdateExpense
{
    public class UpdateExpenseUseCase : IUpdateExpenseUseCase
    {
        private readonly IExpensesRepository _repository;
        private readonly IUnitOfWork _unitOfWork;

        public UpdateExpenseUseCase(IExpensesRepository repository, IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
        }
        public async Task Execute(int id, RequestExpenseJson request)
        {
            ValidadeRequest(request);
            var oldExpense = await _repository.GetById(id);
            if (oldExpense == null)
            {
                throw new NotFoundException(ResourceErrorMessages.EXPENSE_NOT_FOUND);
            }
            var newExpense = ExpenseMapper.ToEntity(request, oldExpense);
            _repository.UpdateExpense(newExpense);
            await _unitOfWork.Commit();
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
}
