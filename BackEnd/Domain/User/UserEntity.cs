using Domain.Transaction;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.User
{
    public class UserEntity
    {
        [Key]
        public Guid Id { get; private set; }

        public string Name { get; private set; }

        public string Email { get; private set; }

        public string CPF { get; private set; }

        public DateOnly BirthDate { get; private set; }

        public string Password { get; private set; }

        public DateTime CreatedAt { get; private set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? UpdatedAt { get; private set; }

        public ICollection<TransactionEntity> Transaction { get; }

        private UserEntity() { }

        public UserEntity(string name, string email, string cpf, DateOnly birthDate, string password)
        {
            Name = name;
            Email = email;
            CPF = cpf;
            BirthDate = birthDate;
            Password = password;
        }

        public void Update(string? name, string? email, string? cpf, DateOnly? birthDate, string? password)
        {
            Name = name;
            Email = email;
            CPF = cpf;
            BirthDate = birthDate.Value;
            Password = password;
        }
    }
}