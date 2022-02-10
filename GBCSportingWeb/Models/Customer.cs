using System.ComponentModel.DataAnnotations;

namespace GBCSportingWeb.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
    }
}
