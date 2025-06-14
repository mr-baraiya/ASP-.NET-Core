using System.ComponentModel.DataAnnotations;

namespace ConsumeAPIDemoProject.Models
{
    public class User
    {
        public int userId { get; set; }
        [Required]
        public string userName { get; set; }
        [Required]
        public string email { get; set; }
        public DateTime createdAt { get; set; } = DateTime.Now;
        public bool isActive { get; set; } = true;
    }
}
