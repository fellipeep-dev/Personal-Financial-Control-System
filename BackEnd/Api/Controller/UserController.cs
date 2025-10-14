using Api.Abstractions;
using Application.Dtos.User;
using Application.UseCases.User.Create;
using Application.UseCases.User.Delete;
using Application.UseCases.User.GetAll;
using Application.UseCases.User.GetById;
using Application.UseCases.User.Update;
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