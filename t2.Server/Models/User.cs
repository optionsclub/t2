using System.ComponentModel.DataAnnotations;

namespace t2.Server.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string FullName { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string PasswordHash { get; set; } = string.Empty;

        public bool IsActive { get; set; } = true;

        public DateTime CreatedDate { get; set; }
            = DateTime.UtcNow;
    }
}