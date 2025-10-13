using Application.Abstractions.UseCases;
using Domain.Entities;
using Domain.Repositories;

namespace Application.Services.Transaction.UseCases
{
    public class GetTransactionByIdUseCase
     (
         ITransactionRepository transactionRepository
     ) : GetByIdUseCase<TransactionEntity>
     (
         transactionRepository
     ), IGetTransactionByIdUseCase
    {
    }
}
