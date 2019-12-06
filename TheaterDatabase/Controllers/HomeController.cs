using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TheaterDatabase.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Crud()
        {
            ViewBag.Message = "Eventually the CRUD tabs";

            return View();
        }

        public ActionResult Analytics()
        {
            ViewBag.Message = "Analytics";

            return View();
        }
    }
}