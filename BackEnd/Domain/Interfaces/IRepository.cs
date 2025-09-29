namespace Domain.Interfaces
{
    public interface IRepository<E> where E : class
    {
        Task AddAsync(E entity);
        Task<IEnumerable<E>> GetAllAsync();
        Task<E?> GetByIdAsync(Guid id);
        Task UpdateAsync(E entity);
        Task DeleteAsync(E entity);
    }
}
