using Api.Abstractions;
using Application.Dtos.Transaction;
using Application.Services.Transaction;
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
