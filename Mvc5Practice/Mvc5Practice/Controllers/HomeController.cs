using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mvc5Practice.Models;

namespace Mvc5Practice.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            using (var context = new StudentDbContext())
            {
                //var student = new Student()
                //{
                //    Name = "Test",
                //    EmailId = "test@gmail.com",
                //    Address = "Test Address",
                //    City = "Test City",
                //    Department = new Department { Id = 1}
                //};
                //context.Students.Add(student);
                //context.SaveChanges();
                var departMent = new Department {Id = 1};
                var student = new Student()
                {
                    Name = "yyy",
                    EmailId = "has been",
                    Address = "Added",
                    City = "in ddd",
                   
                };
                
                //var studentObject = context.Students.FirstOrDefault(x => x.Department.Id == 1);
                //studentObject.City = "xxx";
                //departMent.Students.Add(studentObject);

                var departMents = context.Departments.FirstOrDefault(x => x.Id == 2);
                student.Department = departMents;
                departMents.Students.Add(student);
                context.SaveChanges();

            }
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}