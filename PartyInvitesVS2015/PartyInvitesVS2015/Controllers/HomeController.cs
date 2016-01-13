using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PartyInvitesVS2015.Models;

namespace PartyInvitesVS2015.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        // GET: Home
        //public string Index()
        //{
        //    return "Hello, World!";
        //}
        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Good mooning" : "Good day";
            return View();
        }
        
        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guest)
        {
            if (ModelState.IsValid) // validation of user input po html form
            {
                return View("Thanks", guest);
            }
            else
                return View();
            
        }
    }
}