using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestApp.Controllers
{
    public class Customer
    {
        public string CustomerName { get; set; }
        public string Address { get; set; }
    }

    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            return View ("TestView");
        }
        public string GetWelcomeMessage()
        {
            return "This is the Test MVC application.";
        }
        public Customer GetCustomerInfo()
        {
            Customer cust = new Customer();
            cust.CustomerName = "Paul Henry";
            cust.Address = "Waltham";
            return cust;
        }

    }
}