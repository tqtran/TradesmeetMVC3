using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TradesmeetMVC3.Controllers
{
    public class ItemController : Controller
    {
        //
        // GET: /Item/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Search()
        {
            return View();
        }

        public ActionResult Detail(int id)
        {
            ViewBag.Message = "Viewing Detail for Item " + id;

            return View();
        }

        public ActionResult List()
        {
            return View();
        }

        public ActionResult My()
        {
            return View();
        }

    }
}
