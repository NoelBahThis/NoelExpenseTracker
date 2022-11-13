using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace NoelExpenseTracker.Models
{
    public class Expense
    {
          [Key]
          public int Id { get; set; }

          [DisplayName("Expense Name")]
          [Required]
          public string ExpenseName { get; set; }
          [Required]
          [Range(1, int.MaxValue, ErrorMessage = "Amount must be greater than 0!")]
          public int Amount { get; set; }
     }
}
