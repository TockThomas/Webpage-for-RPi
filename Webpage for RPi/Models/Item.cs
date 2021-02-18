using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Webpage_for_RPi.Models
{
    public class Item
    {
        [Key]
        
        public int Id { get; set; }
        [Required]
        public string Borrower { get; set; }
        [Required]
        public string Lender { get; set; }
        [DisplayName("Item Name")]
        [Required]
        public string ItemName { get; set; }
    }
}