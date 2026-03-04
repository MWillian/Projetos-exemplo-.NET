using CashFlow.Communication.Requests;
using CashFlow.Domain.Entities;

namespace CashFlow.Application.UseCases.Expenses.UpdateExpense
{
    public interface IUpdateExpenseUseCase
    {
        Task Execute(int id, RequestExpenseJson request);
    }
}
