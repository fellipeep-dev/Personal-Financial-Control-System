using Application.Abstractions.UseCases;
using Domain.Entities;
using Domain.Repositories;
using Microsoft.Extensions.Caching.Distributed;

namespace Application.UseCases.Transaction.GetById
{
    public class GetTransactionByIdUseCase
     (
         ITransactionRepository transactionRepository,
         IDistributedCache cache
     ) : GetByIdUseCase<TransactionEntity>
     (
         transactionRepository,
         cache
     ), IGetTransactionByIdUseCase
    {
    }
}
