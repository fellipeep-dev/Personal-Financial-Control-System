using Application.Abstractions.UseCases;
using Domain.Entities;
using Domain.Repositories;

namespace Application.Services.Category.UseCases
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
