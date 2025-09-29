using Domain.Interfaces;

namespace Domain.User
{
    public interface IUserRepository : IRepository<UserEntity>
    {
        Task<UserEntity?> GetUserByEmailAsync(string email);
        Task<UserEntity?> GetUserByCpfAsync(string cpf);
    }
}