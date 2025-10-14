using Application.Helpers;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.Extensions.Caching.Distributed;
using System.Text.Json;

namespace Application.Abstractions.UseCases
{
    public class GetByIdUseCase<TEntity>
     (
        IRepository<TEntity> repository,
        IDistributedCache cache
     ) : IGetByIdUseCase<TEntity> where TEntity : Entity
    {
        private readonly IRepository<TEntity> _repository =  repository;
        private readonly IDistributedCache _cache = cache;

        private static readonly DistributedCacheEntryOptions CacheOptions = new()
        {
            AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(10),
            SlidingExpiration = TimeSpan.FromSeconds(60)
        };

        public async Task<TEntity?> ExecuteAsync(Guid id)
        {
            var cacheKey = CacheKeyHelper.GetItemKey<TEntity>(id);

            var cachedEntity = await _cache.GetStringAsync(cacheKey);

            if(cachedEntity != null)
            {
                return JsonSerializer.Deserialize<TEntity>(cachedEntity);
            }

            var entity = await _repository.GetByIdAsync(id);

            if(entity != null)
            {
                var serializedEntity = JsonSerializer.Serialize(entity);

                await _cache.SetStringAsync(cacheKey, serializedEntity, CacheOptions);
            }

            return entity;
        }
    }
}
