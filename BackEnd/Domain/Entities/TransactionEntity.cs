using Domain.Entities.Enums;

namespace Domain.Entities
{
    public class TransactionEntity : Entity
    {
        public int TotalInCents { get; private set; }

        public TransactionType Type { get; private set; }

        public Guid UserId { get; private set; }
        public UserEntity User { get; private set; }

        public Guid? CategoryId { get; private set; }
        public CategoryEntity? Category { get; private set; }

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
