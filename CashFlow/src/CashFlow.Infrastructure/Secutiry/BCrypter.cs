namespace CashFlow.Domain.Secutiry.Cryptography
{
    public class BCrypter : IPasswordEncripter
    {
        public string Encrypt(string password)
        {
            string passwordHash = BCrypt.Net.BCrypt.HashPassword(password);
            return passwordHash;
        }
    }
}
