using Application.Dtos.Transaction;
using Domain.Entities;
using Domain.Interfaces;

namespace Application.Services.Transaction
{
    public interface ICreateTransactionUseCase : ICreateUseCase<CreateTransactionDto>
    {
    }
    public interface IGetAllTransactionsUseCase : IGetAllUseCase<TransactionEntity>
    {
    }
    public interface IGetTransactionByIdUseCase : IGetByIdUseCase<TransactionEntity>
    {
    }
    public interface IUpdateTransactionUseCase : IUpdateUseCase<UpdateTransactionDto>
    {
    }
    public interface IDeleteTransactionUseCase : IDeleteUseCase
    {
    }
}