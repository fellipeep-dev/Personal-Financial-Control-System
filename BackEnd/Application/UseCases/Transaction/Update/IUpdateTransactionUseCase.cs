using Application.Dtos.Transaction;
using Domain.Interfaces;

namespace Application.UseCases.Transaction.Update
{
    public interface IUpdateTransactionUseCase : IUpdateUseCase<UpdateTransactionDto>
    {
    }
}
