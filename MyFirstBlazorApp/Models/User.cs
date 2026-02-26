using System.ComponentModel.DataAnnotations;

namespace MyFirstBlazorApp.Models
{
    public class User
    {
        [Required(ErrorMessage ="Full Name is Required")]
        public string? FullName { get; set; }

        [Required(ErrorMessage = "Email is Required")]
        public string? Email { get; set; }

        [Required]
        public int? Age { get; set; }
    }
}
