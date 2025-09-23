using Domain.Transaction;

namespace Application.Services.Transaction.UseCases
{
    public class GetTransactionsUseCase(ITransactionRepository transactionRepository) : IGetTransactionsUseCase
    {
        private readonly ITransactionRepository _transactionRepository = transactionRepository;

        public async Task<IEnumerable<TransactionEntity>> ExecuteAsync()
        {
            return await _transactionRepository.GetTransactionsAsync();
        }
    }
}
