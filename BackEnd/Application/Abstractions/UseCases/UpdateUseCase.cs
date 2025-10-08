using AutoMapper;
using Domain.Interfaces;

namespace Application.Abstractions.UseCases
{
    public class UpdateUseCase<TEntity, TUpdateDto>
     (
        IRepository<TEntity> repository,
        IMapper mapper
     ) : IUpdateUseCase<TUpdateDto> where TEntity : class
    {
        private readonly IRepository<TEntity> _repository = repository;
        private readonly IMapper _mapper = mapper;

        public async Task ExecuteAsync(TUpdateDto updateDto)
        {
            var Id = (Guid)typeof(TUpdateDto).GetProperty("Id")?.GetValue(updateDto)!;

            var entity = await _repository.GetByIdAsync(Id) ?? throw new Exception("Entity not found");

            _mapper.Map(updateDto, entity);

            await _repository.UpdateAsync(entity);
        }
    }
}
