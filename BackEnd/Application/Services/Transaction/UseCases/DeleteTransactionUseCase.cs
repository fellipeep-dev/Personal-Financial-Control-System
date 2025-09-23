using Domain.Transaction;

namespace Application.Services.Transaction.UseCases
{
    public class DeleteTransactionUseCase(ITransactionRepository transactionRepository) : IDeleteTransactionUseCase
    {
        public async Task ExecuteAsync(Guid id)
        {
            var transaction = await transactionRepository.GetTransactionByIdAsync(id) ?? throw new Exception("Transaction not found");

            await transactionRepository.DeleteTransactionAsync(transaction);
        }
    }
}
