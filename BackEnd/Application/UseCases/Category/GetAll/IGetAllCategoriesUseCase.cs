using Domain.Entities;
using Domain.Interfaces;

namespace Application.UseCases.Category.GetAll
{
    public interface IGetAllCategoriesUseCase : IGetAllUseCase<CategoryEntity>
    {
    }
}
