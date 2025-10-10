using Application.Abstractions.UseCases;
using Application.Dtos.Transaction;
using AutoMapper;
using Domain.Entities;
using Domain.Repositories;

namespace Application.Services.Transaction.UseCases
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
