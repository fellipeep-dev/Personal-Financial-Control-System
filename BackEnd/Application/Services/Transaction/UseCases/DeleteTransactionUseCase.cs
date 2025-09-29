using Domain.Transaction;

namespace Application.Services.Transaction.UseCases
{
    public class DeleteTransactionUseCase(ITransactionRepository transactionRepository) : IDeleteTransactionUseCase
    {
        public async Task ExecuteAsync(Guid id)
        {
            var transactionEntity = await transactionRepository.GetByIdAsync(id) ?? throw new Exception("Transaction not found");

            await transactionRepository.DeleteAsync(transactionEntity);
        }
    }
}
