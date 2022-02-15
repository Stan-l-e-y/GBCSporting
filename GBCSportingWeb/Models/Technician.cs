using System.ComponentModel.DataAnnotations;

namespace GBCSportingWeb.Models
{
    public class Technician
    {
        [Key]
        public int TechnicianId { get; set; }

        [Required(ErrorMessage = "Please enter a Name")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Please enter an Email")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Please enter a Phone Number")]
        public string? Phone { get; set; }

        public String? Slug => Name?.Replace(' ', '-').ToLower();

    }
}
