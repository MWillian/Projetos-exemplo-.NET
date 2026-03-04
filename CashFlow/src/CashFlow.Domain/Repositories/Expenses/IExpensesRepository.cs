using CashFlow.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashFlow.Domain.Repositories.Expenses
{
    public interface IExpensesRepository
    {
        Task<Expense?> GetById(int id);
        Task AddExpense(Expense expense);
        Task<List<Expense>> GetAllExpenses();
        Task<Expense?> GetExpenseById(int id);
        /// <summary>
        /// This function returns TRUE if the process of deleting the expense was successful, otherwise it returns FALSE.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<bool> Delete(int id);
        void UpdateExpense(Expense expense);
    }
}
