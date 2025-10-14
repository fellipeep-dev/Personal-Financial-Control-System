using Api.Abstractions;
using Application.Dtos.Transaction;
using Application.UseCases.Transaction.Create;
using Application.UseCases.Transaction.Delete;
using Application.UseCases.Transaction.GetAll;
using Application.UseCases.Transaction.GetById;
using Application.UseCases.Transaction.Update;
using Domain.Entities;

namespace Api.Controller
{
    public class TransactionController() : ControllerAbstraction
     <
        TransactionEntity,
        CreateTransactionDto,
        UpdateTransactionDto,
        ICreateTransactionUseCase,
        IGetAllTransactionsUseCase,
        IGetTransactionByIdUseCase,
        IUpdateTransactionUseCase,
        IDeleteTransactionUseCase
     >
    {
    }
}
