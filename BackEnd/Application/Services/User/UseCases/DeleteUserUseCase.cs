using Application.Abstractions.UseCases;
using Domain.Entities;
using Domain.Repositories;

namespace Application.Services.User.UseCases
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