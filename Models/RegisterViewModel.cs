using System.ComponentModel.DataAnnotations;

namespace StudentGradeManagementSystem.Models
{
    public class RegisterViewModel
    {
        [Required]
        public string StudentName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        // Add other properties as needed
    }
}
