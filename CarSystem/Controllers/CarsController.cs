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


    }
}