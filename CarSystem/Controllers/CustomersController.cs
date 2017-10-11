using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CarSystem.Models;

namespace CarSystem.Controllers
{
    public class CustomersController : Controller
    {
 
        // GET: Customers
        public ActionResult Index()
        {
            var customers = GetCustomers();

            return View(customers);
        }

       

        private IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                new Customer {Id = 1, Name = "Mohd Yahya"},
                new Customer {Id = 2, Name = "Ali Ahmed"}

            };
        }

    }
}