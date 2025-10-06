using Domain.Interfaces;

namespace Application.Abstractions.UseCases
{
    public class GetAllUseCase<TEntity>
     (
        IRepository<TEntity> repository
     ) : IGetAllUseCase<TEntity> where TEntity : class
    {
        private readonly IRepository<TEntity> _repository = repository;

        public async Task<IEnumerable<TEntity>> ExecuteAsync()
        {
            return await _repository.GetAllAsync();
        }
    }
}
