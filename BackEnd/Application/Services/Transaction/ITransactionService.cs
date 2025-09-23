using Application.Dtos.Transaction;
using Domain.Transaction;

namespace Application.Services.Transaction
{
    public interface ICreateTransactionUseCase
    {
        Task ExecuteAsync(CreateTransactionDto createTransactionDto);
    }
    public interface IGetTransactionsUseCase
    {
        Task<IEnumerable<TransactionEntity>> ExecuteAsync();
    }
    public interface IGetTransactionByIdUseCase
    {
        Task<TransactionEntity> ExecuteAsync(Guid id);
    }
    public interface IUpdateTransactionUseCase
    {
        Task ExecuteAsync(UpdateTransactionDto updateTransactionDto);
    }
    public interface IDeleteTransactionUseCase
    {
        Task ExecuteAsync(Guid id);
    }
}