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


        private ApplicationDbContext db;

        public CustomersController()
        {
            db = new ApplicationDbContext();
        }

        public ActionResult ShowAllCars()
        {
            var customers = db.Customer.ToList();

            return View(customers);
        }

        public ActionResult CustomersStartWithA()
        {
            var customers = db.Customer.Where(c => c.FirstName.StartsWith("A"));

            return View(customers);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Save(Customer customer)
        {

            if (!ModelState.IsValid)
            {
                return View("Create", customer);
            }

            db.Customer.Add(customer);

            db.SaveChanges();

            return RedirectToAction("Index", "Home");
        }

        // GET: Customers
        public ActionResult Index()
        {

            //var customers = GetCustomers();

            return View();
        }

       

        private IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                new Customer {Id = 1, FirstName = "Mohd Yahya"},
                new Customer {Id = 2, FirstName = "Ali Ahmed"}

            };
        }

    }
}