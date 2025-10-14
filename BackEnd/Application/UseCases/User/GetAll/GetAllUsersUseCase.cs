using Application.Abstractions.UseCases;
using Domain.Entities;
using Domain.Repositories;
using Microsoft.Extensions.Caching.Distributed;

namespace Application.UseCases.User.GetAll
{
    public class GetAllUsersUseCase
     (
         IUserRepository userRepository,
         IDistributedCache cache
     ) : GetAllUseCase<UserEntity>
     (
         userRepository,
         cache
     ), IGetAllUsersUseCase
    {
    }
}