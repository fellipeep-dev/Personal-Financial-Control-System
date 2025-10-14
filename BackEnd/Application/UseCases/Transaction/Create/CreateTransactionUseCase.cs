using Application.Abstractions.UseCases;
using Application.Dtos.Transaction;
using AutoMapper;
using Domain.Entities;
using Domain.Repositories;

namespace Application.UseCases.Transaction.Create
{
    public class CreateTransactionUseCase
     (
         ITransactionRepository transactionRepository,
         IMapper mapper
     ) : CreateUseCase<TransactionEntity, CreateTransactionDto>
     (
         transactionRepository, mapper
     ), ICreateTransactionUseCase
    {
    }
}
