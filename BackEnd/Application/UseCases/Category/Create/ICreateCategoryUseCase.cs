using Application.Dtos.Category;
using Domain.Interfaces;

namespace Application.UseCases.Category.Create
{
    public interface ICreateCategoryUseCase : ICreateUseCase<CreateCategoryDto>
    {
    }
}
