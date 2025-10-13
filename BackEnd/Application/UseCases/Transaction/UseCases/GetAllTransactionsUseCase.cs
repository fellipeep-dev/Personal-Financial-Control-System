using Application.Abstractions.UseCases;
using Domain.Entities;
using Domain.Repositories;

namespace Application.Services.Transaction.UseCases
{
    public class GetAllTransactionsUseCase
     (
         ITransactionRepository transactionRepository
     ) : GetAllUseCase<TransactionEntity>
     (
         transactionRepository
     ), IGetAllTransactionsUseCase
    {
    }
}
