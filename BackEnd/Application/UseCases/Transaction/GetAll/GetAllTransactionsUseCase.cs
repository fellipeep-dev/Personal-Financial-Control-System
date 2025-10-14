using Application.Abstractions.UseCases;
using Domain.Entities;
using Domain.Repositories;

namespace Application.UseCases.Transaction.GetAll
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
