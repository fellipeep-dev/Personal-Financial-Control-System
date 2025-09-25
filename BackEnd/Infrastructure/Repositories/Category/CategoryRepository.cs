using Domain.Category;
using Infrastructure.Database;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories.Category
{
    public class CategoryRepository(AppDbContext context) : ICategoryRepository
    {
        private readonly AppDbContext _context = context;

        public async Task AddCategoryAsync(CategoryEntity category)
        {
            await _context.AddAsync(category);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<CategoryEntity>> GetCategoriesAsync()
        {
            return await _context.Categories.ToListAsync();
        }

        public async Task<CategoryEntity?> GetCategoryByIdAsync(Guid id)
        {
            return await _context.Categories.FindAsync(id);
        }

        public async Task UpdateCategoryAsync(CategoryEntity category)
        {
            _context.Categories.Update(category);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteCategoryAsync(CategoryEntity category)
        {
            _context.Categories.Remove(category);
            await _context.SaveChangesAsync();
        }
    }
}
