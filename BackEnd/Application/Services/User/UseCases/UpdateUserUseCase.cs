using Application.Dtos.User;
using Domain.User;

namespace Application.Services.User.UseCases
{
    public class UpdateUserUseCase(IUserRepository userRepository) : IUpdateUserUseCase
    {
        private readonly IUserRepository _userRepository = userRepository;

        public async Task ExecuteAsync(UpdateUserDto updateUserDto)
        {
            var userEntity = await _userRepository.GetByIdAsync(updateUserDto.Id) ?? throw new Exception("User not found");

            userEntity.Update(
                updateUserDto.Name,
                updateUserDto.Email,
                updateUserDto.Cpf,
                updateUserDto.BirthDate,
                updateUserDto.Password
            );

            await _userRepository.UpdateAsync(userEntity);
        }

    }
}