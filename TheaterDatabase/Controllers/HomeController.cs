using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TheaterDatabase.DAL;
using TheaterDatabase.ViewModels.CRUD_VMs;

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
            ViewBag.Message = "Create, Read, Update, and Delete table info here";

            CRUDVM model = new CRUDVM();
            model._shows_vm.LstShows = ShowsDAL.GetAllShows();

            return View(model);
        }

        //public ActionResult Partials_Shows()
        //{
        //    ShowsVM model = new ShowsVM();
        //    model.LstShows = ShowsDAL.GetAllShows();

        //    return View(model);
        //}

        public ActionResult Analytics()
        {
            ViewBag.Message = "Analytics";

            return View();
        }
    }
}