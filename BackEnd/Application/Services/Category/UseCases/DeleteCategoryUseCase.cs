using Domain.Repositories;

namespace Application.Services.Category.UseCases
{
    public class DeleteCategoryUseCase(ICategoryRepository categoryRepository) : IDeleteCategoryUseCase
    {
        private readonly ICategoryRepository _categoryRepository = categoryRepository;

        public async Task ExecuteAsync(Guid id)
        {
            var categoryEntity = await _categoryRepository.GetByIdAsync(id) ?? throw new Exception("Category not found");

            await categoryRepository.DeleteAsync(categoryEntity);
        }
    }
}
