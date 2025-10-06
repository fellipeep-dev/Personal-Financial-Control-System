using Application.Abstractions.UseCases;
using Domain.Transaction;

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
