using Application.Services.Category;
using Application.Services.Transaction;
using Application.UseCases.User;
using Microsoft.Extensions.DependencyInjection;

namespace Application
{
    public static class ApplicationModuleDependency
    {
        public static void AddApplicationModule(this IServiceCollection services)
        {
            services.AddUserModule();
            services.AddTransactionModule();
            services.AddCategoryModule();
        }
    }
}