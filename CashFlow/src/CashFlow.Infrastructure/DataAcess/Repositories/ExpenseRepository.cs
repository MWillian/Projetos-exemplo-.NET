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

        public async Task<bool> Delete(int id)
        {
            var affectedRows = await _dbContext.Expenses.Where(ex => ex.Id == id).ExecuteDeleteAsync();
            return affectedRows > 0;
        }

        public async Task<List<Expense>> GetAllExpenses()
        {
            return await _dbContext.Expenses.ToListAsync();
        }

        public async Task<Expense?> GetById(int id)
        {
            return await _dbContext.Expenses.FirstOrDefaultAsync(ex => ex.Id == id);
        }

        public async Task<Expense?> GetExpenseById(int id)
        {
            return await _dbContext.Expenses.AsNoTracking().FirstOrDefaultAsync(ex => ex.Id == id);
        }

        public void UpdateExpense(Expense expense)
        {
            _dbContext.Expenses.Update(expense);
        }
    }
}
