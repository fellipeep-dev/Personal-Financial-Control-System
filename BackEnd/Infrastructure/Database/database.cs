using Domain.Category;
using Domain.Transaction;
using Domain.User;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Database
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            foreach(var entityType in modelBuilder.Model.GetEntityTypes())
            {
                var createdAt = entityType.FindProperty("CreatedAt");
                if(createdAt != null && createdAt.ClrType == typeof(DateTime))
                    createdAt.SetDefaultValueSql("CURRENT_TIMESTAMP");
            }
        }

        public DbSet<UserEntity> Users { get; set; }
        public DbSet<TransactionEntity> Transactions { get; set; }
        public DbSet<CategoryEntity> Categories { get; set; }
    }
}