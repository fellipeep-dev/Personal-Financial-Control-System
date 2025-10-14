using Api.Abstractions;
using Application.Dtos.Category;
using Application.UseCases.Category.Create;
using Application.UseCases.Category.Delete;
using Application.UseCases.Category.GetAll;
using Application.UseCases.Category.GetById;
using Application.UseCases.Category.Update;
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
