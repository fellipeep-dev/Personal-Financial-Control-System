using Application.Dtos.User;
using Domain.Services.Hash;
using Domain.User;

namespace Application.Services.User.UseCases
{
    public class CreateUserUseCase(IUserRepository userRepository) : ICreateUserUseCase
    {
        private readonly IUserRepository _userRepository = userRepository;

        public async Task ExecuteAsync(CreateUserDto createUserDto)
        {
            var existingEmail = await _userRepository.GetUserByEmailAsync(createUserDto.Email);

            if (existingEmail != null)
                throw new Exception("Email already in use");

            var existingCpf = await _userRepository.GetUserByCpfAsync(createUserDto.Cpf);

            if (existingCpf != null)
                throw new Exception("CPF already in use");

            var passwordHash = PasswordService.HashPassword(createUserDto.Password);

            var user = new UserEntity(
                createUserDto.Name,
                createUserDto.Email,
                createUserDto.Cpf,
                createUserDto.BirthDate,
                passwordHash
            );

            await _userRepository.AddUserAsync(user);
        }
    }
}
