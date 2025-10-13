using Api.Abstractions;
using Application.Dtos.User;
using Application.UseCases.User.CreateUseCase;
using Application.UseCases.User.DeleteUseCase;
using Application.UseCases.User.GetAllUseCase;
using Application.UseCases.User.GetByIdUseCase;
using Application.UseCases.User.UpdateUseCase;
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