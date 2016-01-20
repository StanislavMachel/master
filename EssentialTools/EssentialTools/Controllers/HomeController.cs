using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EssentialTools.Models;
using Ninject; //for Ninject DI using
namespace EssentialTools.Controllers
{
    public class HomeController : Controller
    {
        private IValueCalculator calc;

        private Product[] products = {
            new Product {Name = "Russian Vodka", Category = "Drinks", Price = 9.99M},
            new Product {Name = "Burger", Category = "Food", Price = 2.99M},
            new Product {Name = "Salat", Category = "Snack", Price = 5.50M},
        };

        public HomeController(IValueCalculator calcParam, IValueCalculator calc2)
        {
            calc = calcParam;
        }

        public ActionResult Index()
        {
            ////LinqValueCalculator calc = new LinqValueCalculator();
            ////ShoppingCart cart = new ShoppingCart(calc)
            ////{
            ////    Products = products
            ////};
            ////decimal totalValue = cart.CalculateProductTotal();
            ////return View(totalValue);

            //IKernel ninjectKernel = new StandardKernel(); // create Ninject core
            //ninjectKernel.Bind<IValueCalculator>().To<LinqValueCalculator>(); // setting current Interface with Object

            //IValueCalculator calc = ninjectKernel.Get<IValueCalculator>(); // using Ninject -> return implementation

            ShoppingCart cart = new ShoppingCart(calc)
            {
                Products = products
            };

            decimal totalValue = cart.CalculateProductTotal();
            return View(totalValue);
        }
    }
}