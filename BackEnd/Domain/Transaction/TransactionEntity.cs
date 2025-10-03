using Domain.Category;
using Domain.User;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Transaction
{
    public enum TransactionType
    {
        ENTRY,
        EXIT
    }

    public class TransactionEntity
    {
        [Key]
        public Guid Id { get; private set; }

        public int TotalInCents { get; private set; }

        public TransactionType Type { get; private set; }

        public DateTime CreatedAt { get; private set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? UpdatedAt { get; private set; }

        public Guid UserId { get; private set; }
        public UserEntity User { get; private set; }

        public Guid? CategoryId { get; private set; }
        public CategoryEntity? Category { get; private set; }

        private TransactionEntity() { }

        public TransactionEntity(Guid userId, Guid? categoryId, int totalInCents, TransactionType type)
        {
            UserId = userId;
            CategoryId = categoryId;
            TotalInCents = totalInCents;
            Type = type;
        }
        public void Update(int? totalInCents, TransactionType? type)
        {
            TotalInCents = totalInCents ?? TotalInCents;
            Type = type ?? Type;
        }
    }
}
