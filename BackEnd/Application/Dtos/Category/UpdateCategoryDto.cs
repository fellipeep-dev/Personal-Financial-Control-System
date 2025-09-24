using Domain.Category;
using System.ComponentModel.DataAnnotations;

namespace Application.Dtos.Category
{
    public class UpdateCategoryDto
    {
        [Required(ErrorMessage = "Id is required")]
        public Guid Id { get; set; }

        public string? Name { get; set; }

        public int? TotalInCents { get; set; }

        public CategoryType? Type { get; set; }
    }
}
