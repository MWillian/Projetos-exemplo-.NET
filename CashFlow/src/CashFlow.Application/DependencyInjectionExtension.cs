using CashFlow.Application.UseCases.Expenses.Register;
using CashFlow.Application.UseCases.Expenses.GetAll;
using Microsoft.Extensions.DependencyInjection;
using CashFlow.Application.UseCases.Expenses.GetById;
using CashFlow.Application.UseCases.Expenses.DeleteById;
using CashFlow.Application.UseCases.Expenses.UpdateExpense;

namespace CashFlow.Application
{
    public static class DependencyInjectionExtension
    {
        public static void AddApplication(this IServiceCollection services)
        {
            AddUseCases(services);
        }
        public static void AddUseCases(this IServiceCollection services)
        {
            services.AddScoped<IRegisterExpenseUseCase, RegisterExpenseUseCase>();
            services.AddScoped<IGetAllExpensesUseCase, GetAllExpensesUseCase>();
            services.AddScoped<IGetExpenseByIdUseCase, GetExpenseByIdUseCase>();
            services.AddScoped<IDeleteExpenseByIdUseCase, DeleteExpenseByIdUseCase>();
            services.AddScoped<IUpdateExpenseUseCase, UpdateExpenseUseCase>();
        }
    }
}
