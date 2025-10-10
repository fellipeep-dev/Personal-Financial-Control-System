using Domain.Entities;
using Domain.Repositories;

namespace Application.Services.User.UseCases
{
    public class GetUserByIdUseCase(IUserRepository userRepository) : IGetUserByIdUseCase
    {
        private readonly IUserRepository _userRepository = userRepository;

        public async Task<UserEntity> ExecuteAsync(Guid id)
        {
            return await _userRepository.GetByIdAsync(id) ?? throw new Exception("User not found");
        }
    }
}