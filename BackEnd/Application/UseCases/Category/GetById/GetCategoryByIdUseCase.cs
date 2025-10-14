using Application.Abstractions.UseCases;
using Domain.Entities;
using Domain.Repositories;
using Microsoft.Extensions.Caching.Distributed;

namespace Application.UseCases.Category.GetById
{
    public class GetCategoryByIdUseCase
     (
         ICategoryRepository categoryRepository,
         IDistributedCache cache
     ) : GetByIdUseCase<CategoryEntity>
     (
         categoryRepository,
         cache
     ), IGetCategoryByIdUseCase
    {
    }
}
