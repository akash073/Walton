using System;
using System.Collections.Generic;
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
                var student = new Student()
                {
                    Name = "Test",
                    EmailId = "test@gmail.com",
                    Address = "Test Address",
                    City = "Test City",
                    TestColumn = "dddd",
                    TestColumn2 = "TestColumn2"
                };
                context.Students.Add(student);
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