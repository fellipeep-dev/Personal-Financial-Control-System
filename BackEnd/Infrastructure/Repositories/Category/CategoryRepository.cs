using Domain.Category;
using Infrastructure.Abstractions;
using Infrastructure.Database;

namespace Infrastructure.Repositories.Category
{
    public class CategoryRepository(AppDbContext context) : Repository<CategoryEntity>(context), ICategoryRepository
    {
    }
}
