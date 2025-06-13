using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetMvcCourse.Controllers
{
    class Employee
    {
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
    }

    public class HomeController : Controller
    {
        readonly Employee[] employees = new Employee[]
        {
            new Employee { EmployeeID = 1, Name = "Scott", Salary = 8000 },
            new Employee { EmployeeID = 2, Name = "Smith", Salary = 2540 },
            new Employee { EmployeeID = 3, Name = "Allen", Salary = 9400 },
        };

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Products()
        {
            return View("OurCompanyProducts");
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult GetEmpName(int employeeID)
        {
            string matchedName = employees.FirstOrDefault(e => e.EmployeeID == employeeID)?.Name;

            //return new ContentResult() { Content = matchedName, ContentType = "text/plain" };
            return Content(matchedName, "text/plain");
        }

        public ActionResult GetPaySlip(int employeeID)
        {
            string fileName = "~/PaySlip" + employeeID + ".pdf";
            return File(fileName, "application/pdf");
        }

        public ActionResult EmpFacebookPage(int employeeID)
        {
            if (!employees.Any(e => e.EmployeeID == employeeID))
                return Content("Invalid employee id");

            string url = "http://www.facebook.com/emp" + employeeID;
            return Redirect(url);
        }
    }
}