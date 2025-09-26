using Isopoh.Cryptography.Argon2;

namespace Domain.Services.Hash
{
    public class PasswordService
    {
        public static string HashPassword(string password)
        {
            return Argon2.Hash(password);
        }

        public static bool VerifyPassword(string hashedPassword, string providedPassword)
        {
            return Argon2.Verify(hashedPassword, providedPassword);
        }
    }
}
