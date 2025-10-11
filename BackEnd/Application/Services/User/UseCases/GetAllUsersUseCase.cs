using Application.Abstractions.UseCases;
using Domain.Entities;
using Domain.Repositories;

namespace Application.Services.User.UseCases
{
    public class GetAllUsersUseCase
     (
         IUserRepository userRepository
     ) : GetAllUseCase<UserEntity>
     (
         userRepository
     ), IGetAllUsersUseCase
    {
    }
}