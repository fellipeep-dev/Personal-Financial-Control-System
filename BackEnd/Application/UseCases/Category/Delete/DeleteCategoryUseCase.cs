using Application.Abstractions.UseCases;
using Domain.Entities;
using Domain.Repositories;

namespace Application.UseCases.Category.Delete
{
    public class DeleteCategoryUseCase
     (
         ICategoryRepository categoryRepository
     ) : DeleteUseCase<CategoryEntity>
     (
         categoryRepository
     ), IDeleteCategoryUseCase
    {
    }
}
