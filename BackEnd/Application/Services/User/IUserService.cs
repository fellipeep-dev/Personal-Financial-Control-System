using Application.Dtos.User;
using Domain.Entities;
using Domain.Interfaces;

namespace Application.Services.User
{
    public interface ICreateUserUseCase : ICreateUseCase<CreateUserDto>
    {
    }
    public interface IGetAllUsersUseCase : IGetAllUseCase<UserEntity>
    {
    }
    public interface IGetUserByIdUseCase : IGetByIdUseCase<UserEntity>
    {
    }
    public interface IUpdateUserUseCase : IUpdateUseCase<UpdateUserDto>
    {
    }
    public interface IDeleteUserUseCase : IDeleteUseCase
    {
    }
}