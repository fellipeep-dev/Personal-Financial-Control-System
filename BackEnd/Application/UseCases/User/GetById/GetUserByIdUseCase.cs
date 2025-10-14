using Application.Abstractions.UseCases;
using Domain.Entities;
using Domain.Repositories;
using Microsoft.Extensions.Caching.Distributed;

namespace Application.UseCases.User.GetById
{
    public class GetUserByIdUseCase
     (
         IUserRepository userRepository,
         IDistributedCache cache
     ) : GetByIdUseCase<UserEntity>
     (
         userRepository,
         cache
     ), IGetUserByIdUseCase
    {
    }
}