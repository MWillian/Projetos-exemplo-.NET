using CashFlow.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CashFlow.Infrastructure.DataAcess;

internal class CashFlowDbContext : DbContext
{
    public DbSet<Expense> Expenses { get; set; }
    public CashFlowDbContext(DbContextOptions<CashFlowDbContext> options) : base(options) { }
}
