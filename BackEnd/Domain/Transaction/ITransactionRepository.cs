namespace Domain.Transaction
{
    public interface ITransactionRepository
    {
        Task AddTransactionAsync(TransactionEntity transaction);
        Task<IEnumerable<TransactionEntity>> GetTransactionsAsync();
        Task<TransactionEntity?> GetTransactionByIdAsync(Guid id);
        Task UpdateTransactionAsync(TransactionEntity transaction);
        Task DeleteTransactionAsync(TransactionEntity transaction);
    }
}
