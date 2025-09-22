using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Transaction
{
    public class TransactionEntity
    {
        [Key]
        public Guid Id { get; private set; }

        public Guid UserId { get; private set; }

        public decimal Amount { get; private set; }

        public string Description { get; private set; }

        public DateTime TransactionDate { get; private set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime CreatedAt { get; private set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime UpdatedAt { get; private set; }

        private TransactionEntity() { }

        public TransactionEntity(Guid userId, decimal amount, string description, DateTime transactionDate)
        {
            UserId = userId;
            Amount = amount;
            Description = description;
            TransactionDate = transactionDate;
        }
        public void Update(decimal? amount, string? description, DateTime? transactionDate)
        {
            Amount = amount ?? Amount;
            Description = description ?? Description;
            TransactionDate = transactionDate ?? TransactionDate;
        }
    }
}
