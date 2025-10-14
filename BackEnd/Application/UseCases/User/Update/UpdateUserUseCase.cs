using Application.Abstractions.UseCases;
using Application.Dtos.User;
using AutoMapper;
using Domain.Entities;
using Domain.Repositories;

namespace Application.UseCases.User.Update
{
    public class UpdateUserUseCase
     (
         IUserRepository userRepository,
         IMapper mapper
     ) : UpdateUseCase<UserEntity, UpdateUserDto>
     (
         userRepository, mapper
     ), IUpdateUserUseCase
    {
    }
}