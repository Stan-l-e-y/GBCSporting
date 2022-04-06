using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GBCSportingWeb.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        [Required(ErrorMessage = "Please enter your first name.")]
        [StringLength(51, MinimumLength = 1)]
        public string? FirstName { get; set; }
        [Required(ErrorMessage = "Please enter your last name.")]
        [StringLength(51, MinimumLength = 1)]
        public string? LastName { get; set; }
        [Required(ErrorMessage = "Please enter your address.")]
        [StringLength(51, MinimumLength = 1)]
        public string? Address { get; set; }
        [Required(ErrorMessage = "Please enter your city.")]
        [StringLength(51, MinimumLength = 1)]
        public string? City { get; set; }
        [Required(ErrorMessage = "Please enter your state.")]
        [StringLength(51, MinimumLength = 1)]
        public string? State { get; set; }
        [Required(ErrorMessage = "Please enter your postal code.")]
        [StringLength(20, MinimumLength = 1)]
        public string? PostalCode { get; set; }
        [Required(ErrorMessage = "Please choose a country.")]
        public int CountryId { get; set; }
        public Country? Country { get; set; }

        [RegularExpression(@"^(\s)?\(?\d{3}\)[\s]\d{3}[\s-]\d{4}$", ErrorMessage = "Phone number must be in (999) 999-9999 format")]
        public string? Phone { get; set; }

        [Required(ErrorMessage = "Please enter your email.")]
        [StringLength(51, MinimumLength = 1)]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.\w+)+)",ErrorMessage = "Please enter a valid email")]
        public string? Email { get; set; }

        public List<Registration>? Regstrations { get; set; }




    }
}
