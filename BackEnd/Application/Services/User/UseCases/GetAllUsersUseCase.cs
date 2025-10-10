using Domain.Entities;
using Domain.Repositories;

namespace Application.Services.User.UseCases
{
    public class GetAllUsersUseCase(IUserRepository userRepository) : IGetAllUsersUseCase
    {
        private readonly IUserRepository _userRepository = userRepository;

        public async Task<IEnumerable<UserEntity>> ExecuteAsync()
        {
            return await _userRepository.GetAllAsync();
        }
    }
}