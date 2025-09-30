using Domain.Transaction;

namespace Application.Services.Transaction.UseCases
{
    public class GetAllTransactionsUseCase(ITransactionRepository transactionRepository) : IGetAllTransactionsUseCase
    {
        private readonly ITransactionRepository _transactionRepository = transactionRepository;

        public async Task<IEnumerable<TransactionEntity>> ExecuteAsync()
        {
            return await _transactionRepository.GetAllAsync();
        }
    }
}
