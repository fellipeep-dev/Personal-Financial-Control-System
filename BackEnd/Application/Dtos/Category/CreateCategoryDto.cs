using Domain.Entities.Enums;
using System.ComponentModel.DataAnnotations;

namespace Application.Dtos.Category
{
    public class CreateCategoryDto
    {
        [Required(ErrorMessage = "UserId is required")]
        public Guid UserId { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "TotalInCents is required")]
        public int TotalInCents { get; set; }

        [Required(ErrorMessage = "Type is required")]
        public CategoryType Type { get; set; }
    }
}
