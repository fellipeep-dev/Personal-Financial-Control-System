using Application.Abstractions.UseCases;
using Domain.Transaction;

namespace Application.Services.Transaction.UseCases
{
    public class DeleteTransactionUseCase
     (
         ITransactionRepository transactionRepository
     ) : DeleteUseCase<TransactionEntity>
     (
         transactionRepository
     ), IDeleteTransactionUseCase
    {
    }
}
