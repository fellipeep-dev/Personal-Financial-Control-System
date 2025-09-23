using Domain.Transaction;

namespace Application.Services.Transaction.UseCases
{
    public class GetTransactionByIdUseCase(ITransactionRepository transactionRepository) : IGetTransactionByIdUseCase
    {
        private readonly ITransactionRepository _transactionRepository = transactionRepository;

        public async Task<TransactionEntity> ExecuteAsync(Guid id)
        {
            return await _transactionRepository.GetTransactionByIdAsync(id) ?? throw new Exception("Transaction not found"); ;
        }
    }
}
