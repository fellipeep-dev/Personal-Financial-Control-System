using Domain.Category;

namespace Application.Services.Category.UseCases
{
    public class DeleteCategoryUseCase(ICategoryRepository categoryRepository) : IDeleteCategoryUseCase
    {
        private readonly ICategoryRepository _categoryRepository = categoryRepository;

        public async Task ExecuteAsync(Guid id)
        {
            var categoryEntity = await _categoryRepository.GetCategoryByIdAsync(id) ?? throw new Exception("Category not found");

            await categoryRepository.DeleteCategoryAsync(categoryEntity);
        }
    }
}
