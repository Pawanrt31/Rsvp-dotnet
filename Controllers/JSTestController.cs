using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RsvpPage.Controllers
{
    public class JSTestController : Controller
    {
        // GET: JSTest
        public ActionResult Index()
        {
            return View("O01_helloJs");

        }
    }
}