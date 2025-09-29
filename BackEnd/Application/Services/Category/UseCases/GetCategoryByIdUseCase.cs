using Domain.Category;

namespace Application.Services.Category.UseCases
{
    public class GetCategoryByIdUseCase(ICategoryRepository categoryRepository) : IGetCategoryByIdUseCase
    {
        private readonly ICategoryRepository _categoryRepository = categoryRepository;
        public async Task<CategoryEntity> ExecuteAsync(Guid id)
        {
            return await _categoryRepository.GetByIdAsync(id) ?? throw new Exception("Category not found");
        }
    }
}
