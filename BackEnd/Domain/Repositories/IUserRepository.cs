using Domain.Entities;
using Domain.Interfaces;

namespace Domain.Repositories
{
    public interface IUserRepository : IRepository<UserEntity>
    {
        Task<UserEntity?> GetUserByEmailAsync(string email);
        Task<UserEntity?> GetUserByCpfAsync(string cpf);
    }
}