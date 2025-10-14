using Application.Abstractions.UseCases;
using Domain.Entities;
using Domain.Repositories;
using Microsoft.Extensions.Caching.Distributed;

namespace Application.UseCases.Transaction.Delete
{
    public class DeleteTransactionUseCase
     (
         ITransactionRepository transactionRepository,
         IDistributedCache cache
     ) : DeleteUseCase<TransactionEntity>
     (
         transactionRepository,
         cache
     ), IDeleteTransactionUseCase
    {
    }
}
