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
            model._exec_vm.LstExec = ExecDAL.GetAllExec();
            model._members_vm.LstMembers = MembersDAL.GetAllMembers();
            model._pits_vm.LstPits = PitsDAL.GetAllPits();
            model._shows_vm.LstShows = ShowsDAL.GetAllShows();
            model._staff_vm.LstStaff = StaffDAL.GetAllStaff();

            return View(model);
        }

        public ActionResult Analytics()
        {
            ViewBag.Message = "Analytics";

            return View();
        }

        #region REGION - CASTS

        /*public ActionResult UpdateCasts()
        {
            return View();
        }*/

        #endregion

        #region REGION - CLUBS

        /*public ActionResult UpdateClubs()
        {
            return View();
        }*/

        #endregion

        #region REGION - DATES

        /*public ActionResult UpdateDates()
        {
            return View();
        }*/

        #endregion

        #region REGION - EXEC

        /*public ActionResult UpdateExec()
        {
            return View();
        }*/

        #endregion

        #region REGION - MEMBERS

        /*public ActionResult UpdeteMembers()
        {
            return View();
        }*/

        #endregion

        #region REGION - PITS

        /*public ActionResult UpdatePits()
        {
            return View();
        }*/

        #endregion

        #region REGION - SHOWS

        /*public ActionResult LstShows()
        {
            ShowsVM vm = ShowsDAL.GetAllShows();
            return 
        }*/

        #endregion

        #region REGION - STAFFS

        /*public ActionResult UpdateStaffs()
        {
            return View();
        }*/

        #endregion
    }
}