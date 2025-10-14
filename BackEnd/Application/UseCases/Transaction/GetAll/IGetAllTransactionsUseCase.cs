using Domain.Entities;
using Domain.Interfaces;

namespace Application.UseCases.Transaction.GetAll
{
    public interface IGetAllTransactionsUseCase : IGetAllUseCase<TransactionEntity>
    {
    }
}
