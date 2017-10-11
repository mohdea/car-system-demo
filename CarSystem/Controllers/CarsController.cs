using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CarSystem.Models;
using CarSystem.ViewModels;

namespace CarSystem.Controllers
{
    public class CarsController : Controller
    {
        private ApplicationDbContext _context;

        public CarsController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: Cars
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        public ActionResult AllCars()
        {
            var cars = _context.Car.Include(c => c.CarType).ToList();

            return View(cars);
        }

        public ActionResult Latest()
        {
            var car = new Car() {Make = "Toyota"};

            var customers = new List<Customer>
            {
                new Customer { Name = "Isa"},
                new Customer { Name = "Mahdi"},
                new Customer { Name = "Zahraa Alnasr"}
            };

            var latestViewModel = new LatestCarViewModel()
            {
                Car = car,
                Customers = customers
            };
            
            return View(latestViewModel);
        }
    }
}