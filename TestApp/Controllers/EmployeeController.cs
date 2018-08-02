using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestApp.Models;
namespace TestApp.Controllers
{
    public class EmployeeController : Controller
    {
        public ActionResult getEmpView()
        {
            Employee emp = new Employee();
            emp.FirstName = "Ravi";
            emp.LastName = "Maharjan";
            emp.Salary = 20000;
            ViewData["Employee"] = emp;
            return View("EmployeeView");
            
        }
    }
}