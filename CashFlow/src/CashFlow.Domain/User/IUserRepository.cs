using CashFlow.Domain.Entities;

namespace CashFlow.Domain.User
{
    public interface IUserRepository
    {
        Task<bool> ExistActiveUserWithEmail(string email);
        Task Add(Entities.User user);
    };
}
