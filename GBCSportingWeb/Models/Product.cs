using System.ComponentModel.DataAnnotations;

namespace GBCSportingWeb.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set;}

        [Required(ErrorMessage = "Please enter product name.")]
        public string? ProductName { get; set; }

        [Required(ErrorMessage = "Please enter the yearly price.")]
        [Range(0, 9999.99, ErrorMessage = "Please enter a positive value.")]
        public double? YearlyPrice { get; set; }

        public DateTime ReleaseDate { get; set; }
    }
}
