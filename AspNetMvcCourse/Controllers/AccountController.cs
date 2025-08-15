using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetMvcCourse.Controllers
{
    public class AccountController : Controller
    {
        public ActionResult Login(string userName, string password)
        {
            if (userName == "admin" && password == "manager")
                return RedirectToAction("Dashboard", "Admin");

            return RedirectToAction("InvalidLogin");
        }

        public ActionResult InvalidLogin()
        {
            return View();
        }
    }
}