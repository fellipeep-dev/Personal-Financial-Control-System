using Domain.Entities.Enums;
using System.ComponentModel.DataAnnotations;

namespace Application.Dtos.Transaction
{
    public class UpdateTransactionDto
    {
        [Required(ErrorMessage = "Id is required")]
        public Guid Id { get; set; }

        public int? TotalInCents { get; set; }

        public TransactionType? Type { get; set; }
    }
}
