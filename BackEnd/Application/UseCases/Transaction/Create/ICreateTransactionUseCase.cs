using Application.Dtos.Transaction;
using Domain.Interfaces;

namespace Application.UseCases.Transaction.Create
{
    public interface ICreateTransactionUseCase : ICreateUseCase<CreateTransactionDto>
    {
    }
}
