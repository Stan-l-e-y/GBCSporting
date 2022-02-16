using System.ComponentModel.DataAnnotations;

namespace GBCSportingWeb.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        [Required(ErrorMessage = "Please enter your first name.")]
        public string? FirstName { get; set; }
        [Required(ErrorMessage = "Please enter your last name.")]
        public string? LastName { get; set; }
        [Required(ErrorMessage = "Please enter your address.")]
        public string? Address { get; set; }
        [Required(ErrorMessage = "Please enter your city.")]
        public string? City { get; set; }
        [Required(ErrorMessage = "Please enter your state.")]
        public string? State { get; set; }
        [Required(ErrorMessage = "Please enter your postal code.")]
        public string? PostalCode { get; set; }
        [Required(ErrorMessage = "Please choose a country.")]
        public int CountryId { get; set; }
        public Country Country { get; set; }

        // The Email and Phone fields are optional
        public string? Phone { get; set; }
        public string? Email { get; set; }

    }
}
