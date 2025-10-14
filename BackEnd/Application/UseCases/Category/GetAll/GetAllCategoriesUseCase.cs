using Application.Abstractions.UseCases;
using Domain.Entities;
using Domain.Repositories;
using Microsoft.Extensions.Caching.Distributed;

namespace Application.UseCases.Category.GetAll
{
    public class GetAllCategoriesUseCase(
         ICategoryRepository categoryRepository,
         IDistributedCache cache
     ) : GetAllUseCase<CategoryEntity>
     (
         categoryRepository,
         cache
     ), IGetAllCategoriesUseCase
    {
    }
}
