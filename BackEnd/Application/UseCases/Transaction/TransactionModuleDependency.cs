using Application.UseCases.Transaction.Create;
using Application.UseCases.Transaction.Delete;
using Application.UseCases.Transaction.GetAll;
using Application.UseCases.Transaction.GetById;
using Application.UseCases.Transaction.Update;
using Microsoft.Extensions.DependencyInjection;

namespace Application.UseCases.Transaction
{
    public static class TransactionModuleDependency
    {
        public static IServiceCollection AddTransactionModule(this IServiceCollection services)
        {
            services.AddTransient<ICreateTransactionUseCase, CreateTransactionUseCase>();
            services.AddTransient<IGetAllTransactionsUseCase, GetAllTransactionsUseCase>();
            services.AddTransient<IGetTransactionByIdUseCase, GetTransactionByIdUseCase>();
            services.AddTransient<IUpdateTransactionUseCase, UpdateTransactionUseCase>();
            services.AddTransient<IDeleteTransactionUseCase, DeleteTransactionUseCase>();

            return services;
        }
    }
}
