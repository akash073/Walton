using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mvc5Practice.Models;
using Mvc5Practice.ViewModels;

namespace Mvc5Practice.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //using (var context = new StudentDbContext())
            //{
            //    //var student = new Student()
            //    //{
            //    //    Name = "Test",
            //    //    EmailId = "test@gmail.com",
            //    //    Address = "Test Address",
            //    //    City = "Test City",
            //    //    Department = new Department { Id = 1}
            //    //};
            //    //context.Students.Add(student);
            //    //context.SaveChanges();
            //    var departMent = new Department { DepartmentId = 1 };
            //    var student = new Student()
            //    {
            //        Name = "yyy",
            //        EmailId = "has been",
            //        Address = "Added",
            //        City = "in ddd",

            //    };

            //    //var studentObject = context.Students.FirstOrDefault(x => x.Department.Id == 1);
            //    //studentObject.City = "xxx";
            //    //departMent.Students.Add(studentObject);
            //    var dept = new Department
            //    {
            //        DepartmentId = 1,
            //        DepartmentName = "Akash"
            //    };
            //    context.Departments.Add(dept);
            //    context.SaveChanges();
            //    var departMents = context.Departments.FirstOrDefault(x => x.DepartmentId == 1);
            //    student.Department = departMents;

            //    if (departMents != null)
            //    {
            //        departMents.Students.Add(student);
            //    }
            //    else
            //    {

            //    }
            //    context.SaveChanges();

            //}

            List<Music> musicFiles = new List<Music>()
            {
                new Music { Music_Id = 123, Song_Name = "foo1" }, 
                new Music { Music_Id = 456, Song_Name = "foo2" }
            };
            return View();
           // return View();
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
        [HttpPost]
        public ActionResult LoginPage(LoginPageVM model)
        {
            //...code to login user to application...
            return View(model);
        }

        //List of Validation
        public ActionResult Create()
        {
            List<Music> musicFiles = new List<Music>()
            {
                new Music { Music_Id = 123, Song_Name = "foo1" }, 
                new Music { Music_Id = 456, Song_Name = "foo2" }
            };
            return View(musicFiles);
        }

        [HttpPost]
        public ActionResult Create(List<Music> musicFiles)
        {
            if (ModelState.IsValid)
                return RedirectToAction("Index");

            return View(musicFiles);
        }

        [HttpPost]
        public ActionResult FormPost()
        {
            String FirstName = Request.Form["FirstName"];
            String LastName = Request.Form["LastName"];
            return View();
        }
    }
}