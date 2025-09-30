using Domain.Category;

namespace Application.Services.Category.UseCases
{
    public class GetAllCategoriesUseCase(ICategoryRepository categoryRepository) : IGetAllCategoriesUseCase
    {
        private readonly ICategoryRepository _categoryRepository = categoryRepository;

        public async Task<IEnumerable<CategoryEntity>> ExecuteAsync()
        {
            return await _categoryRepository.GetAllAsync();
        }
    }
}
