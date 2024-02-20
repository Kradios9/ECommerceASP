using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ECommerceASP.Models
{
    public class Computers
    {
        [Key]
        public int Reference { get; set; }

        [Required]
        [DisplayName("Computer Name")]
        public string ComputerName { get; set; }

        [Required]
        public bool Disponibility { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        [Range(0, 999999, ErrorMessage = "Value of {0} must be between {1} and {2}.")]
        public decimal Price { get; set; }


        public DateTimeOffset CreatedDate { get; set; } = DateTimeOffset.UtcNow;
        //public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}
