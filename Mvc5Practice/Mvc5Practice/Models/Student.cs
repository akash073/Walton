﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Mvc5Practice.Models
{
    public class Student
    {
        public Student()
        {

        }
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public DateTime? DateOfBirth { get; set; }
        public string EmailId { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string TestColumn { get; set; }
        public string TestColumn2 { get; set; }

        public Department Department { get; set; } // Navigation Property
    }
}