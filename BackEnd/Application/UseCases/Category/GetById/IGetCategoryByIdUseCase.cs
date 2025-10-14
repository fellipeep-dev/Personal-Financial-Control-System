using Domain.Entities;
using Domain.Interfaces;

namespace Application.UseCases.Category.GetById
{
    public interface IGetCategoryByIdUseCase : IGetByIdUseCase<CategoryEntity>
    {
    }
}
