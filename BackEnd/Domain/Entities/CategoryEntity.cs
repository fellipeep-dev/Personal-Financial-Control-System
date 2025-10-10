using Domain.Entities.Enums;

namespace Domain.Entities
{
    public class CategoryEntity : Entity
    {
        public string Name { get; private set; }

        public int TotalInCents { get; private set; }

        public CategoryType Type { get; private set; }

        public Guid UserId { get; private set; }
        public UserEntity User { get; private set; }

        public ICollection<TransactionEntity> Transaction { get; }

        public CategoryEntity(Guid userId, string name, int totalInCents, CategoryType type)
        {
            UserId = userId;
            Name = name;
            TotalInCents = totalInCents;
            Type = type;
        }

        public void Update(string? name, int? totalInCents, CategoryType? type)
        {
            Name = name ?? Name;
            TotalInCents = totalInCents ?? TotalInCents;
            Type = type ?? Type;
        }
    }
}
