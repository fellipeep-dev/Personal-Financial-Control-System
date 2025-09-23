using Domain.Transaction;
using Domain.User;
using Infrastructure.Repositories.Transaction;
using Infrastructure.Repositories.User;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure
{
    public static class InfrastructureModuleDependency
    {
        public static void AddInfrastructureModule(this IServiceCollection services)
        {
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<ITransactionRepository, TransactionRepository>();
        }
    }
}