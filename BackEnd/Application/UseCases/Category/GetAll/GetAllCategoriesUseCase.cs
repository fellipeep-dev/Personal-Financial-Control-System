using Application.Abstractions.UseCases;
using Domain.Entities;
using Domain.Repositories;

namespace Application.UseCases.Category.GetAll
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
