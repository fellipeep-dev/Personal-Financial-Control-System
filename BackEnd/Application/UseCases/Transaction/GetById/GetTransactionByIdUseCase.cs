using Application.Abstractions.UseCases;
using Domain.Entities;
using Domain.Repositories;

namespace Application.UseCases.Transaction.GetById
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
