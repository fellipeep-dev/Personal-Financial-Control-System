using Application.UseCases.Category.Create;
using Application.UseCases.Category.Delete;
using Application.UseCases.Category.GetAll;
using Application.UseCases.Category.GetById;
using Application.UseCases.Category.Update;
using Microsoft.Extensions.DependencyInjection;

namespace Application.UseCases.Category
{
    public static class CategoryModuleDependency
    {
        public static IServiceCollection AddCategoryModule(this IServiceCollection services)
        {
            services.AddTransient<ICreateCategoryUseCase, CreateCategoryUseCase>();
            services.AddTransient<IGetAllCategoriesUseCase, GetAllCategoriesUseCase>();
            services.AddTransient<IGetCategoryByIdUseCase, GetCategoryByIdUseCase>();
            services.AddTransient<IUpdateCategoryUseCase, UpdateCategoryUseCase>();
            services.AddTransient<IDeleteCategoryUseCase, DeleteCategoryUseCase>();

            return services;
        }
    }
}
