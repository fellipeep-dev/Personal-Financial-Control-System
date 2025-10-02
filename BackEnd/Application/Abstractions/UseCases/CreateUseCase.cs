using Domain.Interfaces;

namespace Application.Abstractions.UseCases
{
    public class CreateUseCase<TEntity, TCreateDto>(
        IRepository<TEntity> repository
    ) : ICreateUseCase<TCreateDto> where TEntity : class
    {
        private readonly IRepository<TEntity> _repository = repository;

        public async Task ExecuteAsync(TCreateDto createDto)
        {
            var entity = (TEntity)Activator.CreateInstance(typeof(TEntity), createDto)!;

            await _repository.AddAsync(entity);
        }
    }
}
