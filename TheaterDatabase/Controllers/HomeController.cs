﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TheaterDatabase.DAL;
using TheaterDatabase.Models;
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

        #region REGION - CASTS

        public ActionResult InsertCasts(string StrVoicePart, string StrRole, int IntMemberID, int IntShowID)
        {
            Cast newCast = new Cast
            {
                StrVoicePart = StrVoicePart,
                StrRole = StrRole,
                IntMemberID = IntMemberID,
                IntShowID = IntShowID
            };

            bool success = CastsDAL.InsertCast(newCast);

            CastsVM model = new CastsVM()
            {
                LstCasts = CastsDAL.GetAllCasts(),
                LstAllMembers = MembersDAL.GetAllMembers(),
                LstAllShows = ShowsDAL.GetAllShows()
            };


            return PartialView("CRUDPartials/_Casts", model);

        }

        public ActionResult DeleteCasts(int IntCastID)
        {
            Cast remCast = new Cast
            {
                IntCastID = IntCastID
            };

            bool success = CastsDAL.DeleteCast(remCast);

            CastsVM model = new CastsVM()
            {
                LstCasts = CastsDAL.GetAllCasts(),
                LstAllMembers = MembersDAL.GetAllMembers(),
                LstAllShows = ShowsDAL.GetAllShows()
            };


            return PartialView("CRUDPartials/_Casts", model);

        }

        public ActionResult UpdateCasts(int IntCastID, int IntMemberID)
        {
            Cast updCast = new Cast
            {
                IntCastID = IntCastID,
                IntMemberID = IntMemberID
            };

            bool success = CastsDAL.UpdateCast(updCast);

            CastsVM model = new CastsVM()
            {
                LstCasts = CastsDAL.GetAllCasts(),
                LstAllMembers = MembersDAL.GetAllMembers(),
                LstAllShows = ShowsDAL.GetAllShows()
            };


            return PartialView("CRUDPartials/_Casts", model);

        }

        #endregion
    }
}