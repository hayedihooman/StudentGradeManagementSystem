using System.ComponentModel.DataAnnotations;

namespace StudentGradeManagementSystem.Models
{
    public class Students
    {
        [Key]
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string Email { get; set; }


        public List<Course> CoursesTaken { get; set; }
        public List<Course> CoursesInProgress { get; set; }
    }
}
