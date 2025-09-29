using Application.Dtos.Transaction;
using Domain.Transaction;

namespace Application.Services.Transaction.UseCases
{
    public class UpdateTransactionUseCase(ITransactionRepository transactionRepository) : IUpdateTransactionUseCase
    {
        private readonly ITransactionRepository _transactionRepository = transactionRepository;

        public async Task ExecuteAsync(UpdateTransactionDto updateTransactionDto)
        {
            var transactionEntity = await _transactionRepository.GetByIdAsync(updateTransactionDto.Id) ?? throw new Exception("Transaction not found");

            transactionEntity.Update(
                updateTransactionDto.TotalInCents ?? transactionEntity.TotalInCents,
                updateTransactionDto.Type ?? transactionEntity.Type
            );

            await _transactionRepository.UpdateAsync(transactionEntity);
        }
    }
}
