using System.ComponentModel.DataAnnotations;

namespace Application.Dtos.User
{
    public class UpdateUserDto
    {
        [Required(ErrorMessage = "Id is required")]
        public Guid Id { get; set; }

        [StringLength(100, ErrorMessage = "Name can't be longer than 100 characters")]
        public string? Name { get; set; }

        [EmailAddress(ErrorMessage = "Invalid email format")]
        public string? Email { get; set; }

        [RegularExpression(@"^\d{3}\.\d{3}\.\d{3}-\d{2}$", ErrorMessage = "CPF must be in the format 000.000.000-00")]
        public string? Cpf { get; set; }

        public DateOnly? BirthDate { get; set; }

        public string? Password { get; set; }
    }
}