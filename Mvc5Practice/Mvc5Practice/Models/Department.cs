using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Mvc5Practice.Models
{
    public class Department
    {
        public Department()
        {
            Students=new List<Student>();
        }
        [Key]
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }

        public List<Student> Students { get; set; } // Navigation property
    }
}