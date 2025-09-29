using Domain.User;
using Infrastructure.Abstractions;
using Infrastructure.Database;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories.User
{
    public class UserRepository(AppDbContext context) : Repository<UserEntity>(context), IUserRepository
    {
        public async Task<UserEntity?> GetUserByCpfAsync(string cpf)
        {
            return await _dbSet.FirstOrDefaultAsync(u => u.Cpf == cpf);
        }

        public async Task<UserEntity?> GetUserByEmailAsync(string email)
        {
            return await _dbSet.FirstOrDefaultAsync(u => u.Email == email);
        }
    }
}