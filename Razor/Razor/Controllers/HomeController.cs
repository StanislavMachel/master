using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Razor.Models;

namespace Razor.Controllers
{
    public class HomeController : Controller
    {
        Product myProduct = new Product
        {
            ProductID = 1,
            Name = "Russian Vodka",
            Description = "Vodka from Siberia",
            Category = "Drinks",
            Price = 9
        };
        // GET: Home
        public ActionResult Index()
        {
            return View(myProduct);
        }

        public ActionResult NameAndPrice()
        {
            return View(myProduct);
        }

        public ActionResult DemoExpression()
        {
            ViewBag.ProductCount = 1;
            ViewBag.ExpressShip = true;
            ViewBag.ApplyDiscount = false;
            ViewBag.Supplier = null;

            return View(myProduct);
        }

        public ActionResult DemoArray()
        {
            Product[] array = {
                new Product {Name = "Russian Vodka", Price = 9},
                new Product {Name = "Rum", Price = 11},
                new Product {Name = "Cognac", Price = 50},
                new Product {Name = "Whisky", Price = 25}
            };
            return View(array);
        }
    }
}