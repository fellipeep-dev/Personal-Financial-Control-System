using Domain.Repositories;

namespace Application.Services.User.UseCases
{
    public class DeleteUserUseCase(IUserRepository userRepository) : IDeleteUserUseCase
    {
        private readonly IUserRepository _userRepository = userRepository;

        public async Task ExecuteAsync(Guid id)
        {
            var userEntity = await _userRepository.GetByIdAsync(id) ?? throw new Exception("User not found");

            await _userRepository.DeleteAsync(userEntity);
        }
    }
}