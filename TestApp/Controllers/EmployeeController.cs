using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestApp.Models;
using TestApp.ViewModels;
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

            EmployeeViewModel vmEmp = new EmployeeViewModel();
            vmEmp.EmployeeName = emp.FirstName + " " + emp.LastName;
            vmEmp.Salary = emp.Salary.ToString("C");
            if (emp.Salary > 15000)
            {
                vmEmp.SalaryColor = "yellow";
            }
            else
            {
                vmEmp.SalaryColor = "green";
            }

            vmEmp.UserName = "Admin";
            return View("EmployeeView", vmEmp);
            
        }
    }
}