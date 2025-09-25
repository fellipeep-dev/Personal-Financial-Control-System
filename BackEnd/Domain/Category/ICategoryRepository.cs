namespace Domain.Category
{
    public interface ICategoryRepository
    {
        Task AddCategoryAsync(CategoryEntity category);
        Task<IEnumerable<CategoryEntity>> GetCategoriesAsync();
        Task<CategoryEntity?> GetCategoryByIdAsync(Guid id);
        Task UpdateCategoryAsync(CategoryEntity category);
        Task DeleteCategoryAsync(CategoryEntity category);
    }
}
