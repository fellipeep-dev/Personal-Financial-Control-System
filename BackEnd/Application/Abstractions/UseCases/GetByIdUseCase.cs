using Domain.Interfaces;

namespace Application.Abstractions.UseCases
{
    public class GetByIdUseCase<TEntity>
     (
        IRepository<TEntity> repository
     ) : IGetByIdUseCase<TEntity> where TEntity : class
    {
        private readonly IRepository<TEntity> _repository =  repository;

        public async Task<TEntity> ExecuteAsync(Guid id)
        {
            return await _repository.GetByIdAsync(id) ?? throw new Exception("Entity not found");
        }
    }
}
