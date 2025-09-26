namespace Domain.User
{
    public interface IUserRepository
    {
        Task AddUserAsync(UserEntity user);
        Task<IEnumerable<UserEntity>> GetUsersAsync();
        Task<UserEntity?> GetUserByIdAsync(Guid id);
        Task<UserEntity?> GetUserByEmailAsync(string email);
        Task<UserEntity?> GetUserByCpfAsync(string cpf);
        Task UpdateUserAsync(UserEntity user);
        Task DeleteUserAsync(UserEntity user);
    }
}