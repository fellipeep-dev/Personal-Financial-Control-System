using AutoMapper;
using Domain.Interfaces;

namespace Application.Abstractions.UseCases
{
    public class CreateUseCase<TEntity, TCreateDto>(
        IRepository<TEntity> repository,
        IMapper mapper
    ) : ICreateUseCase<TCreateDto> where TEntity : class
    {
        private readonly IRepository<TEntity> _repository = repository;
        private readonly IMapper _mapper = mapper;

        public async Task ExecuteAsync(TCreateDto createDto)
        {
            var entity = _mapper.Map<TEntity>(createDto);

            await _repository.AddAsync(entity);
        }
    }
}
