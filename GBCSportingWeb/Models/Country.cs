using System.ComponentModel.DataAnnotations;

namespace GBCSportingWeb.Models
{
    public class Country
    {
        [Key]
        public int CountryId { get; set; }
        [Required]
        public string? Name { get; set; }    
    }
}
