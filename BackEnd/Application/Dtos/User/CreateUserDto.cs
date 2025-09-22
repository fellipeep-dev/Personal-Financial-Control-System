namespace Application.Dtos.User
{
    public class CreateUserDto
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public string CPF { get; set; }

        public DateOnly BirthDate { get; set; }

        public string Password { get; set; }
    }
}