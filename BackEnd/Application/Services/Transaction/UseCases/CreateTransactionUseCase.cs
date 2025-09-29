using Application.Dtos.Transaction;
using Domain.Transaction;

namespace Application.Services.Transaction.UseCases
{
    public class CreateTransactionUseCase(ITransactionRepository transactionRepository) : ICreateTransactionUseCase
    {
        private readonly ITransactionRepository _transactionRepository = transactionRepository;

        public async Task ExecuteAsync(CreateTransactionDto createTransactionDto)
        {
            var transaction = new TransactionEntity(
                createTransactionDto.UserId,
                createTransactionDto.CategoryId,
                createTransactionDto.TotalInCents,
                createTransactionDto.Type
            );

            await _transactionRepository.AddAsync(transaction);
        }
    }
}
