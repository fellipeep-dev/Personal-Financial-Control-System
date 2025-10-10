using Application.Dtos.Category;
using Domain.Entities;
using Domain.Repositories;

namespace Application.Services.Category.UseCases
{
    public class CreateCategoryUseCase(ICategoryRepository categoryRepository) : ICreateCategoryUseCase
    {
        private readonly ICategoryRepository _categoryRepository = categoryRepository;

        public async Task ExecuteAsync(CreateCategoryDto createCategoryDto)
        {
            var category = new CategoryEntity(
                createCategoryDto.UserId,
                createCategoryDto.Name,
                createCategoryDto.TotalInCents,
                createCategoryDto.Type
            );

            await _categoryRepository.AddAsync(category);
        }
    }
}
