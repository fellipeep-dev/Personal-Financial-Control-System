namespace Domain.Entities
{
    public class UserEntity : Entity
    {
        public string Name { get; private set; }

        public string Email { get; private set; }

        public string Cpf { get; private set; }

        public DateOnly BirthDate { get; private set; }

        public string Password { get; private set; }

        public ICollection<TransactionEntity> Transaction { get; }

        public ICollection<CategoryEntity> Category { get; }

        public UserEntity(string name, string email, string cpf, DateOnly birthDate, string password)
        {
            Name = name;
            Email = email;
            Cpf = cpf;
            BirthDate = birthDate;
            Password = password;
        }

        public void Update(string? name, string? email, string? cpf, DateOnly? birthDate, string? password)
        {
            Name = name ?? Name;
            Email = email ?? Email;
            Cpf = cpf ?? Cpf;
            BirthDate = birthDate ?? BirthDate;
            Password = password ?? Password;
        }
    }
}