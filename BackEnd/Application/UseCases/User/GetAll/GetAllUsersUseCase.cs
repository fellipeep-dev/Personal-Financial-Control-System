using Application.Abstractions.UseCases;
using Domain.Entities;
using Domain.Repositories;

namespace Application.UseCases.User.GetAll
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