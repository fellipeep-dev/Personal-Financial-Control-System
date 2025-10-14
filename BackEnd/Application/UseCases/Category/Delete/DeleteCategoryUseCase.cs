using Application.Abstractions.UseCases;
using Domain.Entities;
using Domain.Repositories;
using Microsoft.Extensions.Caching.Distributed;

namespace Application.UseCases.Category.Delete
{
    public class DeleteCategoryUseCase
     (
         ICategoryRepository categoryRepository,
         IDistributedCache cache
     ) : DeleteUseCase<CategoryEntity>
     (
         categoryRepository,
         cache
     ), IDeleteCategoryUseCase
    {
    }
}
