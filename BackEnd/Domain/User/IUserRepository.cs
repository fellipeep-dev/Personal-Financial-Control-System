namespace Domain.User
{
    public interface IUserRepository
    {
        Task AddUserAsync(UserEntity user);
        Task<IEnumerable<UserEntity>> GetUsersAsync();
        Task<UserEntity?> GetUserByIdAsync(Guid id);
        Task UpdateUserAsync(UserEntity user);
        Task DeleteUserAsync(UserEntity user);
    }
}