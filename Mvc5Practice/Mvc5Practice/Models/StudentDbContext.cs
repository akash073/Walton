using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Mvc5Practice.Models
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext()
            : base("StudentDbContext")
        {
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Department> Departments { get; set; }
    }
}