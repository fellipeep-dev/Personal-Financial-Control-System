using Api.Abstractions;
using Application.Dtos.Category;
using Application.Services.Category;
using Domain.Entities;

namespace Api.Controller
{
    public class CategoryController() : ControllerAbstraction
     <
        CategoryEntity,
        CreateCategoryDto,
        UpdateCategoryDto,
        ICreateCategoryUseCase,
        IGetAllCategoriesUseCase,
        IGetCategoryByIdUseCase,
        IUpdateCategoryUseCase,
        IDeleteCategoryUseCase
     >
    {
    }
}
