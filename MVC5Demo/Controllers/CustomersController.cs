using MVC5Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5Demo.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult New()
        {
            Customer customer = new Customer
            {
                Name = "Phil",
                Id = 1,
                Counts = new List<int>() { 1, 2, 3, 4 }
            };
            return View(customer);
        }

        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult Create(Customer customer)
        {
            if (!ModelState.IsValid)
            {
                Customer c = new Customer
                {
                    Name = "Phil",
                    Id = 1,
                    Counts = new List<int>() { 1, 2, 3, 4 }
                };
                return View("New", c);
            }
            return View();
        }
    }
}