using Application.Abstractions.UseCases;
using Domain.Entities;
using Domain.Repositories;

namespace Application.UseCases.User.GetByIdUseCase
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