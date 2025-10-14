using Application.Helpers;
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.Extensions.Caching.Distributed;

namespace Application.Abstractions.UseCases
{
    public class CreateUseCase<TEntity, TCreateDto>(
        IRepository<TEntity> repository,
        IDistributedCache cache,
        IMapper mapper
    ) : ICreateUseCase<TCreateDto> where TEntity : Entity
    {
        private readonly IRepository<TEntity> _repository = repository;
        private readonly IDistributedCache _cache = cache;
        private readonly IMapper _mapper = mapper;

        private readonly string _cacheKeyAll = CacheKeyHelper.GetListKey<TEntity>();

        public async Task ExecuteAsync(TCreateDto createDto)
        {
            var entity = _mapper.Map<TEntity>(createDto);

            await _repository.AddAsync(entity);

            await _cache.RemoveAsync(_cacheKeyAll);
        }
    }
}
