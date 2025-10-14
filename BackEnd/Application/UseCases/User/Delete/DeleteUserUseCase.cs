using Application.Abstractions.UseCases;
using Domain.Entities;
using Domain.Repositories;
using Microsoft.Extensions.Caching.Distributed;

namespace Application.UseCases.User.Delete
{
    public class DeleteUserUseCase
     (
         IUserRepository userRepository,
         IDistributedCache cache
     ) : DeleteUseCase<UserEntity>
     (
         userRepository,
         cache
     ), IDeleteUserUseCase
    {
    }
}