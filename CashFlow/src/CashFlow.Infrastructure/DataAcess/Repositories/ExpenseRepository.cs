using CashFlow.Domain.Entities;
using CashFlow.Domain.Repositories.Expenses;
using Microsoft.EntityFrameworkCore;

namespace CashFlow.Infrastructure.DataAcess.Repositories
{
    internal class ExpenseRepository : IExpensesRepository
    {
        private readonly CashFlowDbContext _dbContext;
        public ExpenseRepository(CashFlowDbContext dbcontext)
        {
            _dbContext = dbcontext;
        }
        public async Task AddExpense(Expense expense)
        {
            await _dbContext.Expenses.AddAsync(expense);
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
}
