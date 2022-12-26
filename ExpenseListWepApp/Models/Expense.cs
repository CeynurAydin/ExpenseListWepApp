using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ExpenseListWepApp.Models
{
    public class Expense
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Expense Name")]
        public string ExpenseName { get; set; }
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "You entered wrong value")]
        public int Amount { get; set; }

    }
}
