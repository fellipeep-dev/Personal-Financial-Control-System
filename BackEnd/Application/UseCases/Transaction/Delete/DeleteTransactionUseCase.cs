using Application.Abstractions.UseCases;
using Domain.Entities;
using Domain.Repositories;

namespace Application.UseCases.Transaction.Delete
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
