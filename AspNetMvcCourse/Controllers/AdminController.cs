using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace AspNetMvcCourse.Controllers
{
    public class AdminController : Controller
    {
        public ActionResult Dashboard()
        {
            return View();
        }
    }
}