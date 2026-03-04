using CashFlow.Application.UseCases.Expenses.GetById;
using CashFlow.Domain.Repositories.Expenses;
using CashFlow.Exception;
using CashFlow.Exception.ExceptionBase;

namespace CashFlow.Application.UseCases.Expenses.DeleteById
{
    public class DeleteExpenseByIdUseCase : IDeleteExpenseByIdUseCase
    {
        private readonly IExpensesRepository _repository;
        private readonly IUnitOfWork _unitOfWork;

        public DeleteExpenseByIdUseCase(IExpensesRepository repository, IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
        }

        public async Task Execute(int id)
        {
            Validate(id);
            var result = await _repository.Delete(id);
            if (result is false)
            {
                throw new NotFoundException(ResourceErrorMessages.EXPENSE_NOT_FOUND);
            }
            await _unitOfWork.Commit();
        }
        public void Validate(int id)
        {
            var validator = new GetExpenseByIdValidator();
            var result = validator.Validate(id);
            if (!result.IsValid)
            {
                var errorsList = result.Errors.Select(x => x.ErrorMessage).ToList();
                throw new ErrorOnValidationException(errorsList);
            }
        }
    }
}
