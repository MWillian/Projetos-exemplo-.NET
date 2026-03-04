using CashFlow.Application.Mappers;
using CashFlow.Communication.Responses;
using CashFlow.Domain.Repositories.Expenses;
using CashFlow.Exception;
using CashFlow.Exception.ExceptionBase;

namespace CashFlow.Application.UseCases.Expenses.GetById
{

    public class GetExpenseByIdUseCase : IGetExpenseByIdUseCase
    {
        private readonly IExpensesRepository _repository;

        public GetExpenseByIdUseCase(IExpensesRepository repository)
        {
            _repository = repository;
        }

        public async Task<ResponseShortExpenseJson?> Execute(int id)
        {
            Validate(id);
            var result = await _repository.GetExpenseById(id);
            if (result is null)
            {
                throw new NotFoundException(ResourceErrorMessages.EXPENSE_NOT_FOUND);
            }
            return ExpenseMapper.ToShortResponse(result);
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
