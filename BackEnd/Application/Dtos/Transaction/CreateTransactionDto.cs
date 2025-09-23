using Domain.Transaction;
using System.ComponentModel.DataAnnotations;

namespace Application.Dtos.Transaction
{
    public class CreateTransactionDto
    {
        [Required(ErrorMessage = "UserId is required")]
        public Guid UserId { get; set; }

        [Required(ErrorMessage = "TotalInCents is required")]
        public int TotalInCents { get; set; }

        [Required(ErrorMessage = "Type is required")]
        public TransactionType Type { get; set; }
    }
}
