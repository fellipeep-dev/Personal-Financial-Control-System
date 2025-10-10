using Application.Abstractions.UseCases;
using Domain.Entities;
using Domain.Repositories;

namespace Application.Services.Category.UseCases
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
