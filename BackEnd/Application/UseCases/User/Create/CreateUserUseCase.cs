using Application.Dtos.User;
using AutoMapper;
using Domain.Entities;
using Domain.Repositories;
using Domain.Services.Hash;

namespace Application.UseCases.User.Create
{
    public class CreateUserUseCase(IUserRepository userRepository, IMapper mapper) : ICreateUserUseCase
    {
        private readonly IUserRepository _userRepository = userRepository;
        private readonly IMapper _mapper = mapper;

        public async Task ExecuteAsync(CreateUserDto createUserDto)
        {
            var existingEmail = await _userRepository.GetUserByEmailAsync(createUserDto.Email);

            if (existingEmail != null)
                throw new Exception("Email already in use");

            var existingCpf = await _userRepository.GetUserByCpfAsync(createUserDto.Cpf);

            if (existingCpf != null)
                throw new Exception("CPF already in use");

            var user = _mapper.Map<UserEntity>(createUserDto);

            user.HashPassword(PasswordService.HashPassword(createUserDto.Password));

            await _userRepository.AddAsync(user);
        }
    }
}
