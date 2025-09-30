using Api.Abstractions;
using Application.Dtos.Category;
using Application.Services.Category;
using Domain.Category;

namespace Api.Controller
{
    public class CategoryController : ControllerAbstraction
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
