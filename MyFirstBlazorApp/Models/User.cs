using System.ComponentModel.DataAnnotations;

namespace MyFirstBlazorApp.Models
{
    public class User
    {
        [Required(ErrorMessage = "Full Name is required")]
        //[StringLength(25, MinimumLength = 5, ErrorMessage = "Full Name must be between 5 and 25 characters")]
        [MinLength(5, ErrorMessage = "Full Name must be at least 5 characters")]
        [MaxLength(25, ErrorMessage = "Full Name must be at most 25 characters")]
        public string? FullName { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email format")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Age is required")]
        [Range(1, 100, ErrorMessage = "Age must be between 1 and 100.")]
        public int? Age { get; set; }

        [Required(ErrorMessage ="Password is Required.")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$", ErrorMessage = "Password must be at least 8 characters long and include at least one uppercase letter, one lowercase letter, one number, and one special character.")]
        public string? Password { get; set; }

        [Required(ErrorMessage = "Confirm Password is Required.")]
        [Compare("Password", ErrorMessage = "Passwords do not match.")]
        public string? ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Phone Number is required")]
        [Phone(ErrorMessage = "Phone Number must be exactly 10 digits.")]
        public string? PhoneNumber { get; set; }

        [Required(ErrorMessage = "Profile URL is required")]
        [Url(ErrorMessage = "Invalid URL format")]
        public string? Url { get; set; }

        [Required(ErrorMessage = "Credit Card Number is required")]
        [CreditCard(ErrorMessage ="Invalid Credit Card Number.")]
        public string? CreditCardNumber { get; set; }

    }
}