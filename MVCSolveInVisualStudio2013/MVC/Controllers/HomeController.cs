using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC.Models;

namespace MVC.Controllers
{
    public class District
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<Coordinate> Polygon { get; set; }

        public bool Deleted { get; set; }

        //public District()
        //{
        //    Polygon = new List<Coordinate>();
        //}
    }
    public class Coordinate
    {
        public int Id { get; set; }

        public double Latitude { get; set; }

        public double Longitude { get; set; }
    }
    public class Employee
    {
        public string Name { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
    }
    public class HomeController : Controller
    {
        [HttpPost]
        public JsonResult AddEmployee(Employee obj)
        {
            //AddDetails(obj);

            return Json(obj);
        }
        public ActionResult Index()
        {
            List<ClientModel> clientModels = new List<ClientModel>();
            ClientModel clientModel = new ClientModel
            {
                NumberofClient = 10
            };
            clientModels.Add(clientModel);
            return View(clientModels);
        }
        [HttpPost]
        public ActionResult Index(List<ClientModel> model)
        {
            
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
        [HttpPost]
        public District AddDistrict(District district)
        {
            int a=0;

            int b = a;
            //DistrictModelValidator validator = new DistrictModelValidator();
            //var checkedDistirct = validator.Validate(district, ruleSet: "AddDistrict");
            //if (!checkedDistirct.IsValid)
            //{
            //    return Json(new { success = false }, JsonRequestBehavior.AllowGet);
            //}
            //else
            //{
            //    string statusMessage = districtManager.addDistrict(district.Name);
            //    if (statusMessage == "Error") { return Json(new { success = false }, JsonRequestBehavior.AllowGet); }
            //    else
            //    {
            //        var districts = districtManager.getDistricts();
            //        return Json(new { success = true, districts }, JsonRequestBehavior.AllowGet);
            //    }
            //}
            return district;
        }
    }
}