using SQLite;
using System.ComponentModel.DataAnnotations;
using MaxLengthAttribute = System.ComponentModel.DataAnnotations.MaxLengthAttribute;

using SoftPos.Utilities;
namespace SoftPos.Data.User
{
    public class UserMaster
    {
        [PrimaryKey, AutoIncrement]
        public int UserId { get; set; }

        [Required]
        [MaxLength(255)] // Reasonable length for username
        public string Username { get; set; }

        [Required]
        [MaxLength(255)]
        public string Email { get; set; }

        [Required]
        [MinLength(6, ErrorMessage = "Password must be at least 6 characters.")]
        public string Password { get; set; } // Store hashed password

        [MaxLength(50)]
        public string Role { get; set; } // User roles, e.g., Admin, User, etc.
        public bool IsEmailVerified { get; set; }

        public bool IsActive { get; set; } = true; // Flag for activation status
        public string Image { get; set; }

        public DateTime? AddedDate { get; set; } = DateTimeHelper.Now;

        public DateTime? ModifiyDate { get; set; }
        [Ignore]
        public string NewPassword { get; set; }
        [Ignore]
        public string OldPassword { get; set; }
    }
}
