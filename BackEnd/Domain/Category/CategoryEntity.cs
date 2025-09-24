using Domain.User;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Category
{
    public enum CategoryType
    {
        INCOME,
        EXPENSE
    }

    public class CategoryEntity
    {
        [Key]
        public Guid Id { get; private set; }

        public string Name { get; private set; }

        public int TotalInCents { get; private set; }

        public CategoryType Type { get; private set; }

        public DateTime CreatedAt { get; private set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime UpdatedAt { get; private set; }

        public Guid UserId { get; private set; }
        public UserEntity User { get; private set; }

        private CategoryEntity() { }

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
