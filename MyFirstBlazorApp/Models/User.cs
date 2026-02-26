using System.ComponentModel.DataAnnotations;

namespace MyFirstBlazorApp.Models
{
    public class User
    {
        [Required(ErrorMessage = "Full Name is required")]
        [StringLength(25, MinimumLength = 5, ErrorMessage = "Full Name must be between 5 and 25 characters")]
        public string? FullName { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email format")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Age is required")]
        [Range(1, 100, ErrorMessage = "Age must be between 1 and 100.")]
        public int? Age { get; set; }
    }
}