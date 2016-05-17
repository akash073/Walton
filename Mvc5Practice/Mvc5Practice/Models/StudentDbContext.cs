using System.Data.Entity;

namespace Mvc5Practice.Models
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext()
            : base("StudentDbContext")
        {
        }
        //public DbSet<Student> Students { get; set; }
        //public DbSet<Department> Departments { get; set; }
        //public DbSet<Course> Courses { get; set; }
        public DbSet<QuizAdminViewModel> QuizAdminViewModels { get; set; }


    }
}