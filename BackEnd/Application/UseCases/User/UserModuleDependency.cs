using Application.UseCases.User.CreateUseCase;
using Application.UseCases.User.DeleteUseCase;
using Application.UseCases.User.GetAllUseCase;
using Application.UseCases.User.GetByIdUseCase;
using Application.UseCases.User.UpdateUseCase;
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