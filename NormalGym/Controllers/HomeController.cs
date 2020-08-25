using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NormalGym.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Schedule()
        {
            return PartialView("_Schedule");
        }

        public ActionResult About()
        {
            return PartialView("About");
        }

        public ActionResult Contact()
        {
            return PartialView("Contact");
        }

        public ActionResult _Home()
        {
            return PartialView("_Home");
        }
    }
}