using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using StudentGradeManagementSystem.Models;

namespace StudentGradeManagementSystem.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<StudentGradeManagementSystem.Models.Course> Course { get; set; } = default!;
        public DbSet<StudentGradeManagementSystem.Models.Students> Students { get; set; } = default!;
        public DbSet<StudentGradeManagementSystem.Models.Users> Users { get; set; } = default!;
    }
}