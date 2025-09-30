using Application.Services.Transaction.UseCases;
using Microsoft.Extensions.DependencyInjection;

namespace Application.Services.Transaction
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
