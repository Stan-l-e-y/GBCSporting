using System.ComponentModel.DataAnnotations;
namespace GBCSportingWeb.Models
{
    public class Registration
    {
        [Key]
        public int Id { get; set; }

        public int CustomerId { get; set; }

        public Customer? Customer { get; set; }

        public int ProductId { get; set; }

        public Product? Product { get; set; }

    }
}
