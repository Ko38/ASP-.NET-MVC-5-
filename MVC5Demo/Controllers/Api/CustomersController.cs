using MVC5Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MVC5Demo.Controllers.Api
{
    public class CustomersController : ApiController
    {
        //GET /api/customers
        public List<Customer> GetCustomers()
        {
            List<Customer> customers = new List<Customer>
            {
                new Customer{Name="Phil" },
                new Customer{Name="Bob" },
                new Customer{Name="Alice" }
            };
            return customers;
        }
    }
}
