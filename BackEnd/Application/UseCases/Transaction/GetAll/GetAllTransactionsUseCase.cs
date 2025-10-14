using Application.Abstractions.UseCases;
using Domain.Entities;
using Domain.Repositories;
using Microsoft.Extensions.Caching.Distributed;

namespace Application.UseCases.Transaction.GetAll
{
    public class GetAllTransactionsUseCase
     (
         ITransactionRepository transactionRepository,
         IDistributedCache cache
     ) : GetAllUseCase<TransactionEntity>
     (
         transactionRepository,
         cache
     ), IGetAllTransactionsUseCase
    {
    }
}
