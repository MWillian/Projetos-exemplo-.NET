using FluentValidation;

namespace CashFlow.Application.UseCases.Expenses.GetById
{
    public class GetExpenseByIdValidator : AbstractValidator<int>
    {
        public GetExpenseByIdValidator ()
        {
            RuleFor(id => id).GreaterThan(0).WithMessage("Id must be greater than 0.");
        }
    }
}
