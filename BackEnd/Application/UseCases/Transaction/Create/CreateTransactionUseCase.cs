using Application.Abstractions.UseCases;
using Application.Dtos.Transaction;
using AutoMapper;
using Domain.Entities;
using Domain.Repositories;
using Microsoft.Extensions.Caching.Distributed;

namespace Application.UseCases.Transaction.Create
{
    public class CreateTransactionUseCase
     (
         ITransactionRepository transactionRepository,
         IDistributedCache cache,
         IMapper mapper
     ) : CreateUseCase<TransactionEntity, CreateTransactionDto>
     (
         transactionRepository,
         cache,
         mapper
     ), ICreateTransactionUseCase
    {
    }
}
