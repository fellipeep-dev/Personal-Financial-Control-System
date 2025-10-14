using Application.Abstractions.UseCases;
using Application.Dtos.User;
using AutoMapper;
using Domain.Entities;
using Domain.Repositories;
using Microsoft.Extensions.Caching.Distributed;

namespace Application.UseCases.User.Update
{
    public class UpdateUserUseCase
     (
         IUserRepository userRepository,
         IDistributedCache cache,
         IMapper mapper
     ) : UpdateUseCase<UserEntity, UpdateUserDto>
     (
         userRepository,
         cache,
         mapper
     ), IUpdateUserUseCase
    {
    }
}