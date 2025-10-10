using Domain.Entities;
using Domain.Interfaces;

namespace Application.Abstractions.UseCases
{
    public class DeleteUseCase<TEntity>
     (
        IRepository<TEntity> repository
     ) : IDeleteUseCase where TEntity : Entity
    {
        private readonly IRepository<TEntity> _repository = repository;

        public async Task ExecuteAsync(Guid id)
        {
            var entity = await _repository.GetByIdAsync(id) ?? throw new Exception("Entity not found");

            await _repository.DeleteAsync(entity);
        }
    }
}
