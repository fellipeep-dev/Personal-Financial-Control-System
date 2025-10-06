using Application.Abstractions.UseCases;
using Application.Dtos.Transaction;
using AutoMapper;
using Domain.Transaction;

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
