using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mvc5Practice.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }

        public List<Student> Students { get; set; }
    }
}