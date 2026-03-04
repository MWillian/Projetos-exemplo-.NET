using CashFlow.Domain.Repositories.Expenses;
using CashFlow.Infrastructure.DataAcess;
using CashFlow.Infrastructure.DataAcess.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CashFlow.Infrastructure
{
    public static class DependencyInjectionExtension
    {
        public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration, string connectionString)
        {
            AddRepositories(services, configuration, connectionString);
        }
        private static void AddRepositories(IServiceCollection services, IConfiguration configuration, string connectionString)
        {
            var serverVersion = new MySqlServerVersion(new Version(8, 0, 45));
            services.AddDbContext<CashFlowDbContext>(options =>
                options.UseMySql(connectionString, serverVersion));
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IExpensesRepository, ExpenseRepository>();

        }
    }
}
