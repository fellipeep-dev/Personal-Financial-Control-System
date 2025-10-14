using Application.Abstractions.UseCases;
using Application.Dtos.Transaction;
using AutoMapper;
using Domain.Entities;
using Domain.Repositories;
using Microsoft.Extensions.Caching.Distributed;

namespace Application.UseCases.Transaction.Update
{
    public class UpdateTransactionUseCase
     (
         ITransactionRepository transactionRepository,
         IDistributedCache cache,
         IMapper mapper
     ) : UpdateUseCase<TransactionEntity, UpdateTransactionDto>
     (
         transactionRepository,
         cache,
         mapper
     ), IUpdateTransactionUseCase
    {
    }
}
