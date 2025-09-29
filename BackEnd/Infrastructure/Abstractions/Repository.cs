using Domain.Interfaces;
using Infrastructure.Database;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Abstractions
{
    public class Repository<E>(AppDbContext context) : IRepository<E> where E : class
    {
        protected readonly AppDbContext _context = context;
        protected readonly DbSet<E> _dbSet = context.Set<E>();

        public async Task AddAsync(E entity)
        {
            await _dbSet.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<E>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<E?> GetByIdAsync(Guid id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task UpdateAsync(E entity)
        {
            _dbSet.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(E entity)
        {
            _dbSet.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}
