using Application.UseCases.User.Create;
using Application.UseCases.User.Delete;
using Application.UseCases.User.GetAll;
using Application.UseCases.User.GetById;
using Application.UseCases.User.Update;
using Microsoft.Extensions.DependencyInjection;

namespace Application.UseCases.User
{
    public static class UserModuleDependency
    {
        public static IServiceCollection AddUserModule(this IServiceCollection services)
        {
            services.AddTransient<ICreateUserUseCase, CreateUserUseCase>();
            services.AddTransient<IGetUserByIdUseCase, GetUserByIdUseCase>();
            services.AddTransient<IGetAllUsersUseCase, GetAllUsersUseCase>();
            services.AddTransient<IUpdateUserUseCase, UpdateUserUseCase>();
            services.AddTransient<IDeleteUserUseCase, DeleteUserUseCase>();

            return services;
        }
    }
}