using Application.Abstractions.UseCases;
using Domain.Entities;
using Domain.Repositories;

namespace Application.UseCases.Category.GetById
{
    public class GetCategoryByIdUseCase
     (
         ICategoryRepository categoryRepository
     ) : GetByIdUseCase<CategoryEntity>
     (
         categoryRepository
     ), IGetCategoryByIdUseCase
    {
    }
}
