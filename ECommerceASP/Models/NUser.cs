using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ECommerceASP.Models
{
    public class NUser
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [DisplayName("User Name")]
        public string Name { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        [Range(10.00, 999.00, ErrorMessage ="Value of {0} must be between {1} and {2}.")]
        public decimal Price { get; set; }

        public DateTimeOffset CreatedDate { get; set; } = DateTimeOffset.UtcNow;
        //public DateTime CreatedDate { get; set; } = DateTime.Now;

    }
}
