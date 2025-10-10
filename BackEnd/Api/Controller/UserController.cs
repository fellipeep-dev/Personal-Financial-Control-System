using Api.Abstractions;
using Application.Dtos.User;
using Application.Services.User;
using Domain.Entities;

namespace Api.Controller
{
    public class UserController() : ControllerAbstraction
     <
        UserEntity,
        CreateUserDto,
        UpdateUserDto,
        ICreateUserUseCase,
        IGetAllUsersUseCase,
        IGetUserByIdUseCase,
        IUpdateUserUseCase,
        IDeleteUserUseCase
     >
    {
    }
}