using CashFlow.Domain.Repositories.Expenses;
using CashFlow.Domain.Secutiry.Cryptography;
using CashFlow.Domain.Secutiry.Tokens;
using CashFlow.Domain.User;
using CashFlow.Infrastructure.DataAcess;
using CashFlow.Infrastructure.DataAcess.Repositories;
using CashFlow.Infrastructure.Secutiry.Tokens;
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
            services.AddScoped<IPasswordEncripter, BCrypter>();
            AddToken(services, configuration);
        }
        private static void AddRepositories(IServiceCollection services, IConfiguration configuration, string connectionString)
        {
            var serverVersion = new MySqlServerVersion(new Version(8, 0, 45));
            services.AddDbContext<CashFlowDbContext>(options =>
                options.UseMySql(connectionString, serverVersion));
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IExpensesRepository, ExpenseRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
        }

        private static void AddToken(IServiceCollection services, IConfiguration configuration)
        {
            var expireTimeMinutes = configuration.GetValue<uint>("Settings:Jwt:ExpiresMinutes");
            var signingKey = configuration.GetValue<string>("Settings:Jwt:SigningKey");
            services.AddScoped<IAcessTokenGenerator>(config => new JwtTokenGenerator(expireTimeMinutes, signingKey!));
        }
    }
}
