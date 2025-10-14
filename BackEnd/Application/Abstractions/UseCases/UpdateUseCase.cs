using Application.Helpers;
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.Extensions.Caching.Distributed;

namespace Application.Abstractions.UseCases
{
    public class UpdateUseCase<TEntity, TUpdateDto>
     (
        IRepository<TEntity> repository,
        IDistributedCache cache,
        IMapper mapper
     ) : IUpdateUseCase<TUpdateDto> where TEntity : Entity
    {
        private readonly IRepository<TEntity> _repository = repository;
        private readonly IDistributedCache _cache = cache;
        private readonly IMapper _mapper = mapper;

        private readonly string _cacheKeyAll = CacheKeyHelper.GetListKey<TEntity>();

        public async Task ExecuteAsync(TUpdateDto updateDto)
        {
            var Id = (Guid)typeof(TUpdateDto).GetProperty("Id")?.GetValue(updateDto)!;

            var entity = await _repository.GetByIdAsync(Id) ?? throw new Exception("Entity not found");

            var cacheKey = CacheKeyHelper.GetItemKey<TEntity>(entity.Id);

            _mapper.Map(updateDto, entity);

            await _repository.UpdateAsync(entity);

            await _cache.RemoveAsync(cacheKey);

            await _cache.RemoveAsync(_cacheKeyAll);
        }
    }
}
