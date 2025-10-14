using Application.Helpers;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.Extensions.Caching.Distributed;
using System.Text.Json;

namespace Application.Abstractions.UseCases
{
    public class GetAllUseCase<TEntity>
     (
        IRepository<TEntity> repository,
        IDistributedCache cache
     ) : IGetAllUseCase<TEntity> where TEntity : Entity
    {
        private readonly IRepository<TEntity> _repository = repository;
        private readonly IDistributedCache _cache = cache;

        private readonly string _cacheKeyAll = CacheKeyHelper.GetListKey<TEntity>();

        private static readonly DistributedCacheEntryOptions CacheOptions = new()
        {
            AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(5),
        };

        public async Task<IEnumerable<TEntity>> ExecuteAsync()
        {
            var cachedEntities = await _cache.GetStringAsync(_cacheKeyAll);

            if(cachedEntities != null)
            {
                return JsonSerializer.Deserialize<IEnumerable<TEntity>>(cachedEntities) ?? [];
            }

            var entities = await _repository.GetAllAsync();

            if(entities.Any())
            {
                var serializedEntities = JsonSerializer.Serialize(entities);

                await _cache.SetStringAsync(_cacheKeyAll, serializedEntities, CacheOptions);
            }

            return entities;
        }
    }
}
