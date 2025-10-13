using Application.Abstractions.UseCases;
using Domain.Entities;
using Domain.Repositories;

namespace Application.Services.Category.UseCases
{
    public class GetAllCategoriesUseCase(
         ICategoryRepository categoryRepository
     ) : GetAllUseCase<CategoryEntity>
     (
         categoryRepository
     ), IGetAllCategoriesUseCase
    {
    }
}
