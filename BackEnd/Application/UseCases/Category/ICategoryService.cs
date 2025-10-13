using Application.Dtos.Category;
using Domain.Entities;
using Domain.Interfaces;

namespace Application.Services.Category
{
    public interface ICreateCategoryUseCase : ICreateUseCase<CreateCategoryDto>
    {
    }
    public interface IGetAllCategoriesUseCase : IGetAllUseCase<CategoryEntity>
    {
    }
    public interface IGetCategoryByIdUseCase : IGetByIdUseCase<CategoryEntity>
    {
    }
    public interface IUpdateCategoryUseCase : IUpdateUseCase<UpdateCategoryDto>
    {
    }
    public interface IDeleteCategoryUseCase : IDeleteUseCase
    {
    }
}
