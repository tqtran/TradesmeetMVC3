using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TradesmeetMVC3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to Tradesmeet";
            //Home Page Content logic goes here.  Most likely from DB
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
