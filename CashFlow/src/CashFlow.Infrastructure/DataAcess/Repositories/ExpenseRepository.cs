using CashFlow.Domain.Entities;
using CashFlow.Domain.Repositories.Expenses;

namespace CashFlow.Infrastructure.DataAcess.Repositories;

internal class ExpenseRepository : IExpensesRepository
{
    public void AddExpense(Expense expense)
    {
        var dbContext = new CashFlowDbContext();
        dbContext.Expenses.Add(expense);
        dbContext.SaveChanges();
    }

    public void DeleteExpense(Expense expense)
    {
        throw new NotImplementedException();
    }

    public void UpdateExpense(Expense expense)
    {
        throw new NotImplementedException();
    }
}