using Application.Abstractions.UseCases;
using Application.Dtos.Transaction;
using AutoMapper;
using Domain.Transaction;

namespace Application.Services.Transaction.UseCases
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
