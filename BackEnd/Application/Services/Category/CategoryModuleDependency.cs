using Application.Services.Category.UseCases;
using Microsoft.Extensions.DependencyInjection;

namespace Application.Services.Category
{
    public static class CategoryModuleDependency
    {
        public static IServiceCollection AddCategoryModule(this IServiceCollection services)
        {
            services.AddTransient<ICreateCategoryUseCase, CreateCategoryUseCase>();
            services.AddTransient<IGetCategoriesUseCase, GetCategoriesUseCase>();
            services.AddTransient<IGetCategoryByIdUseCase, GetCategoryByIdUseCase>();
            services.AddTransient<IUpdateCategoryUseCase, UpdateCategoryUseCase>();
            services.AddTransient<IDeleteCategoryUseCase, DeleteCategoryUseCase>();

            return services;
        }
    }
}
