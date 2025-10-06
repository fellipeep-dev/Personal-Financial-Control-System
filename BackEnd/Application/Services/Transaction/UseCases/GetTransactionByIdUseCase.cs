using Application.Abstractions.UseCases;
using Domain.Transaction;

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
