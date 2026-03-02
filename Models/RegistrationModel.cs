using System.ComponentModel.DataAnnotations;

namespace EventEase.Models
{
    public class Registration
    {
        [Required(ErrorMessage = "Name is required.")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address.")]
        public string? Email { get; set; }

        public int EventId { get; set; }
    }
}
