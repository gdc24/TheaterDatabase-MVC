using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
            model._casts_vm.LstCasts = CastsDAL.GetAllCasts();
            model._casts_vm.LstAllMembers = MembersDAL.GetAllMembers();
            model._casts_vm.LstAllShows = ShowsDAL.GetAllShows();
            model._exec_vm.LstExec = ExecDAL.GetAllExec();
            model._members_vm.LstMembers = model._casts_vm.LstAllMembers;
            model._pits_vm.LstPits = PitsDAL.GetAllPits();
            model._shows_vm.LstShows = model._casts_vm.LstAllShows;
            model._shows_vm.LstAllClubs = ClubsDAL.GetAllClubs();
            model._staff_vm.LstStaff = StaffDAL.GetAllStaff();

            return View(model);
        }

        public ActionResult Analytics()
        {
            ViewBag.Message = "Analytics";

            return View();
        }

        #region REGION - SHOWS

        //public ActionResult LstShows()
        //{
        //    ShowsVM vm = ShowsDAL.GetAllShows();
        //    return 
        //}

        #endregion
    }
}