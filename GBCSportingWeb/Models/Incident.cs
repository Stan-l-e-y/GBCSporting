using System.ComponentModel.DataAnnotations;

namespace GBCSportingWeb.Models
{
    public class Incident
    {
        [Key]
        public int IncidentId { get; set; }

        [Required]
        public string? Title { get; set; }

        public string? Description { get; set; }

        [Range(1, 1000, ErrorMessage = "Please select a Customer")]
        public int CustomerId { get; set; }

        public Customer? Customer { get; set; }

        [Range(1, 1000, ErrorMessage = "Please select a Product")]
        public int ProductId { get; set; }

        public Product? Product { get; set; }

        public int? TechnicianId { get; set; }

        public Technician? Technician { get; set; }

        [Display(Name = "Date Opened"), DataType(DataType.Date)]
        public DateTime? DateOpened { get; set; }

        [Display(Name = "Date Closed"), DataType(DataType.Date)]
        public DateTime? DateClosed { get; set; }
    }
}
