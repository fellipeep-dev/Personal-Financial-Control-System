using Domain.Entities;
using Domain.Repositories;
using Infrastructure.Abstractions;
using Infrastructure.Database;

namespace Infrastructure.Repositories.Transaction
{
    public class TransactionRepository(AppDbContext context) : Repository<TransactionEntity>(context), ITransactionRepository
    {
    }
}
