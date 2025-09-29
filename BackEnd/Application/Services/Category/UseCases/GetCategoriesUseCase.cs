using Domain.Category;

namespace Application.Services.Category.UseCases
{
    public class GetCategoriesUseCase(ICategoryRepository categoryRepository) : IGetCategoriesUseCase
    {
        private readonly ICategoryRepository _categoryRepository = categoryRepository;

        public async Task<IEnumerable<CategoryEntity>> ExecuteAsync()
        {
            return await _categoryRepository.GetAllAsync();
        }
    }
}
