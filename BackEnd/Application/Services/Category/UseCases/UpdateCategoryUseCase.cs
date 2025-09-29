using Application.Dtos.Category;
using Domain.Category;

namespace Application.Services.Category.UseCases
{
    public class UpdateCategoryUseCase(ICategoryRepository categoryRepository) : IUpdateCategoryUseCase
    {
        private readonly ICategoryRepository _categoryRepository = categoryRepository;

        public async Task ExecuteAsync(UpdateCategoryDto updateCategoryDto)
        {
            var categoryEntity = await _categoryRepository.GetByIdAsync(updateCategoryDto.Id) ?? throw new Exception("Transaction not found");
        
            categoryEntity.Update(
                updateCategoryDto.Name ?? categoryEntity.Name,
                updateCategoryDto.TotalInCents ?? categoryEntity.TotalInCents,
                updateCategoryDto.Type ?? categoryEntity.Type
            );

            await _categoryRepository.UpdateAsync(categoryEntity);
        }
    }
}
