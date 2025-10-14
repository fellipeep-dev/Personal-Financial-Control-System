using Application.Abstractions.UseCases;
using Application.Dtos.Transaction;
using AutoMapper;
using Domain.Entities;
using Domain.Repositories;

namespace Application.UseCases.Transaction.Update
{
    public class UpdateTransactionUseCase
     (
         ITransactionRepository transactionRepository,
         IMapper mapper
     ) : UpdateUseCase<TransactionEntity, UpdateTransactionDto>
     (
         transactionRepository, mapper
     ), IUpdateTransactionUseCase
    {
    }
}
