using Application.Abstractions.UseCases;
using Domain.Entities;
using Domain.Repositories;

namespace Application.UseCases.User.DeleteUseCase
{
    public class DeleteUserUseCase
     (
         IUserRepository userRepository
     ) : DeleteUseCase<UserEntity>
     (
         userRepository
     ), IDeleteUserUseCase
    {
    }
}