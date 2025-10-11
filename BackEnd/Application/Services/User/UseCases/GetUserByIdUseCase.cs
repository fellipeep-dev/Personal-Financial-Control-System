using Application.Abstractions.UseCases;
using Domain.Entities;
using Domain.Repositories;

namespace Application.Services.User.UseCases
{
    public class GetUserByIdUseCase
     (
         IUserRepository userRepository
     ) : GetByIdUseCase<UserEntity>
     (
         userRepository
     ), IGetUserByIdUseCase
    {
    }
}