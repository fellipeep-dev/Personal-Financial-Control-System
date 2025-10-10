using Domain.Entities;
using Domain.Repositories;
using Infrastructure.Abstractions;
using Infrastructure.Database;

namespace Infrastructure.Repositories.Category
{
    public class CategoryRepository(AppDbContext context) : Repository<CategoryEntity>(context), ICategoryRepository
    {
    }
}
