using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using AspUpdateAjax.ViewModels;

namespace AspUpdateAjax.Controllers
{

    public class SecurityController : Controller
    {
        // GET: Security
        [AllowAnonymous]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(UserLoginViewModel user)
        {
            // To acces data using LINQ
            // DataClassesDataContext mobjentity = new DataClassesDataContext();
            if (ModelState.IsValid)
            {
                int a = 0;
                if (user.UserName == "akash")
                {
                    FormsAuthentication.SetAuthCookie(user.UserName, true);
                    return Redirect("/Admin/Index");
                }

            }
            return View("Index");
        }
    }
}