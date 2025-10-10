using Application.Abstractions.UseCases;
using Domain.Entities;
using Domain.Repositories;

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
