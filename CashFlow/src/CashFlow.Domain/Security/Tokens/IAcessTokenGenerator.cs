using CashFlow.Domain.Entities;

namespace CashFlow.Domain.Secutiry.Tokens
{
    public interface IAcessTokenGenerator
    {
        string Generate(Entities.User user);
    }
}
