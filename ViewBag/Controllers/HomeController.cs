using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewBag.Models;

namespace ViewBag.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var listOfPersons = new List<Persons>()
            {
                new Persons()
                {
                    Id = 1,
                    FirstName = "Omid",
                    LastName = "Nasri",
                    Age = 23
                },
                new Persons()
                {
                    Id = 2,
                    FirstName = "Sadar",
                    LastName = "Kurd",
                    Age = 22
                }
            };
            ViewBag.Persons = listOfPersons;
            return View();
        }
    }
}