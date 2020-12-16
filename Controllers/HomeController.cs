using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RsvpPage.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public string Index()  //Default
        {
            return "Index action";
        }


        public string About(int id)  //Parameterised with k and id id will take from route.config
        {
            return $"About action id={id}";
        }
        [HttpGet]
        public ActionResult Contact()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Contact(int x=0,int y=0)

        {
            ViewBag.fruits = x;
            ViewBag.vegetable = y;
            return View("Complete");

        }

    }
}