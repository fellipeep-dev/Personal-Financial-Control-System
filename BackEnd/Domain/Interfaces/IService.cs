namespace Domain.Interfaces
{
    public interface ICreateUseCase<TCreateDto>
    {
        Task ExecuteAsync(TCreateDto createDto);
    }
    public interface IGetAllUseCase<TEntity>
    {
        Task<IEnumerable<TEntity>> ExecuteAsync();
    }
    public interface IGetByIdUseCase<TEntity>
    {
        Task<TEntity> ExecuteAsync(Guid id);
    }
    public interface IUpdateUseCase<TUpdateDto>
    {
        Task ExecuteAsync(TUpdateDto updateUserDto);
    }
    public interface IDeleteUseCase
    {
        Task ExecuteAsync(Guid id);
    }
}
