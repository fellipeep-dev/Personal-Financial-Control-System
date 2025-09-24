using Domain.User;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Categories
{
    public enum CategoriesType
    {
        INCOME,
        EXPENSE
    }

    public class CategoriesEntity
    {
        [Key]
        public Guid Id { get; private set; }

        public string Name { get; private set; }

        public int TotalInCents { get; private set; }

        public CategoriesType Type { get; private set; }

        public DateTime CreatedAt { get; private set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime UpdatedAt { get; private set; }

        public Guid UserId { get; private set; }
        public UserEntity User { get; private set; }

        private CategoriesEntity() { }

        public CategoriesEntity(Guid userId, string name, int totalInCents, CategoriesType type)
        {
            UserId = userId;
            Name = name;
            TotalInCents = totalInCents;
            Type = type;
        }

        public void Update(string? name, int? totalInCents, CategoriesType? type)
        {
            Name = name ?? Name;
            TotalInCents = totalInCents ?? TotalInCents;
            Type = type ?? Type;
        }
    }
}
