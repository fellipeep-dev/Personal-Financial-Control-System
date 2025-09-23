using Domain.Transaction;
using Infrastructure.Database;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories.Transaction
{
    public class TransactionRepository(AppDbContext context) : ITransactionRepository
    {
        private readonly AppDbContext _context = context;

        public async Task AddTransactionAsync(TransactionEntity transaction)
        {
            await _context.Transactions.AddAsync(transaction);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<TransactionEntity>> GetTransactionsAsync()
        {
            return await _context.Transactions.ToListAsync();
        }

        public async Task<TransactionEntity?> GetTransactionByIdAsync(Guid id)
        {
            return await _context.Transactions.FindAsync(id);
        }

        public async Task UpdateTransactionAsync(TransactionEntity transaction)
        {
            _context.Transactions.Update(transaction);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteTransactionAsync(TransactionEntity transaction)
        {
            _context.Transactions.Remove(transaction);
            await _context.SaveChangesAsync();
        }
    }
}
