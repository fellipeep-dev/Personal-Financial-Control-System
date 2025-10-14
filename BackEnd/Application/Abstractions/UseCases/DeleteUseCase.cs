using Application.Helpers;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.Extensions.Caching.Distributed;

namespace Application.Abstractions.UseCases
{
    public class DeleteUseCase<TEntity>
     (
        IRepository<TEntity> repository,
        IDistributedCache cache
     ) : IDeleteUseCase where TEntity : Entity
    {
        private readonly IRepository<TEntity> _repository = repository;
        private readonly IDistributedCache _cache = cache;

        private readonly string _cacheKeyAll = CacheKeyHelper.GetListKey<TEntity>();

        public async Task ExecuteAsync(Guid id)
        {
            var entity = await _repository.GetByIdAsync(id) ?? throw new Exception("Entity not found");

            var cacheKey = CacheKeyHelper.GetItemKey<TEntity>(entity.Id);

            await _repository.DeleteAsync(entity);

            await _cache.RemoveAsync(cacheKey);

            await _cache.RemoveAsync(_cacheKeyAll);
        }
    }
}
