using Application.Dtos.Category;
using Domain.Category;

namespace Application.Services.Category
{
    public interface ICreateCategoryUseCase
    {
        Task ExecuteAsync(CreateCategoryDto createCategoryDto);
    }
    public interface IGetCategoriesUseCase
    {
        Task<IEnumerable<CategoryEntity>> ExecuteAsync();
    }
    public interface IGetCategoryByIdUseCase
    {
        Task<CategoryEntity> ExecuteAsync(Guid id);
    }
    public interface IUpdateCategoryUseCase
    {
        Task ExecuteAsync(UpdateCategoryDto updateCategoryDto);
    }
    public interface IDeleteCategoryUseCase
    {
        Task ExecuteAsync(Guid id);
    }
}
