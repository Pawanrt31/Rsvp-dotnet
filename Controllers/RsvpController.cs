using MyNs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RsvpPage.Controllers
{
    public class RsvpController : Controller
    {
        // GET: Rsvp
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Friend friend)
        {
            ViewBag.frnd = friend;
            return View("Thanks");
        }
    }
}