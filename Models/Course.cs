namespace StudentGradeManagementSystem.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public string CourseTitle { get; set; }
        public string CourseName { get; set; }
        public string Semester { get; set; }
        public int Year { get; set; }
        public string Grade { get; set; } // "In Progress" or the actual grade
    }
}
