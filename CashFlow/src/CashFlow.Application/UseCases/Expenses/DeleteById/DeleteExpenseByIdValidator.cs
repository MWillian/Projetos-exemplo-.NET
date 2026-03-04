using FluentValidation;
namespace CashFlow.Application.UseCases.Expenses.DeleteById
{
    public class DeleteExpenseByIdValidator : AbstractValidator<int>
    {
        public DeleteExpenseByIdValidator()
        {
            RuleFor(id => id).GreaterThan(0).WithMessage("Id must be greater than 0.");
        }
    }
}
