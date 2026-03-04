using CashFlow.Communication.Requests;
using CashFlow.Communication.Responses;
using CashFlow.Domain.Entities;
using CashFlow.Domain.Enums;

namespace CashFlow.Application.Mappers
{
    public static class ExpenseMapper
    {
        public static Expense ToEntity(this RequestExpenseJson request)
        {
            return new Expense
            {
                Amount = request.Ammount,
                Date = request.Date,
                Description = request.Description,
                Payment = (PaymentType)request.Payment,
                Title = request.Title
            };
        }
        public static Expense ToEntity(this RequestExpenseJson request, Expense expenseToMap)
        {
            expenseToMap.Amount = request.Ammount;
            expenseToMap.Date = request.Date;
            expenseToMap.Description = request.Description;
            expenseToMap.Payment = (PaymentType)request.Payment;
            expenseToMap.Title = request.Title;
            return expenseToMap;
        }

        public static ResponseRegisterExpenseJson ToResponse(Expense expense)
        {
            return new ResponseRegisterExpenseJson
            {
                Id = expense.Id,
                Description = expense.Description,
                Title = expense.Title
            };
        }

        public static ResponseShortExpenseJson ToShortResponse(Expense expense)
        {
            return new ResponseShortExpenseJson
            {
                Id = expense.Id,
                Description = expense.Description,
                Title = expense.Title,
                Amount = expense.Amount
            };
        }
    }
}
