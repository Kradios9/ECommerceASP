using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ECommerceASP.Models
{
    public class Categories
    {
        [Key]
        public int? Id { get; set; }

        public string Category { get; set; }

        [Range(0, 99, ErrorMessage ="Quantite doit etre entre {1} et {2}")]
        public decimal TotalNb { get; set; }
   
    }
}
