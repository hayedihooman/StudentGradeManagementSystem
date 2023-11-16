using System.ComponentModel.DataAnnotations;

namespace StudentGradeManagementSystem.Models
{
    public class Users
    {
        [Key]
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; } // "Admin" or "Student"
    }
}
