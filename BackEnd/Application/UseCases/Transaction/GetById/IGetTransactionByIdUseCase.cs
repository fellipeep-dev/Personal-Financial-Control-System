using Domain.Entities;
using Domain.Interfaces;

namespace Application.UseCases.Transaction.GetById
{
    public interface IGetTransactionByIdUseCase : IGetByIdUseCase<TransactionEntity>
    {
    }
}
