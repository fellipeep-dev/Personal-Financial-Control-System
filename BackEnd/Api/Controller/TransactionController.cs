using Api.Abstractions;
using Application.Dtos.Transaction;
using Application.Services.Transaction;
using Domain.Transaction;

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
