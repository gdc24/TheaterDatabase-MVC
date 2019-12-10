using System;
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

        public ActionResult InsertShows(string StrName, string StrAuthor, int IntBudget, bool YsnIsMusical, int IntClubID, int IntDateID)
        {
            Show newShow = new Show
            {
                StrName = StrName,
                StrAuthor = StrAuthor,
                IntBudget = IntBudget,
                YsnIsMusical = YsnIsMusical,
                IntClubID = IntClubID,
                Club = ClubsDAL.GetClub(IntClubID),
                IntDateID = IntDateID,
                Date = DatesDAL.GetDate(IntDateID)
            };

            bool success = ShowsDAL.InsertShow(newShow);

            ShowsVM model = new ShowsVM()
            {
                LstAllClubs = ClubsDAL.GetAllClubs(),
                LstShows = ShowsDAL.GetAllShows()
            };

            return PartialView("CRUDPartials/_Shows", model);
        }

        public ActionResult DeleteShows(int IntShowID)
        {
            Show remShow = new Show
            {
                IntShowID = IntShowID
            };

            bool success = ShowsDAL.DeleteShow(remShow);
            
            ShowsVM model = new ShowsVM()
            {
                LstAllClubs = ClubsDAL.GetAllClubs(),
                LstShows = ShowsDAL.GetAllShows()
            };

            return PartialView("CRUDPartials/_Shows", model);
        }

        public ActionResult UpdateShows(int IntShowID, int IntBudget)
        {
            Show upShow = new Show
            {
                IntShowID = IntShowID,
                IntBudget = IntBudget
            };

            bool success = ShowsDAL.UpdateShow(upShow);

            ShowsVM model = new ShowsVM()
            {
                LstAllClubs = ClubsDAL.GetAllClubs(),
                LstShows = ShowsDAL.GetAllShows()
            };

            return PartialView("CRUDPartials/_Shows", model);
        }

        #endregion

        #region REGION - STAFFS

        public ActionResult InsertStaffs(string StrPosition, int IntMemberID, int IntShowID)
        {
            Staff newStaff = new Staff
            {
                StrPosition = StrPosition,
                IntMemberID = IntMemberID,
                Member = MembersDAL.GetMember(IntMemberID),
                IntShowID = IntShowID,
                Show = ShowsDAL.GetShow(IntShowID)
            };

            bool success = StaffDAL.InsertStaff(newStaff);

            StaffVM model = new StaffVM()
            {
                LstStaff = StaffDAL.GetAllStaff()
            };

            return PartialView("CRUDPartials/_Staff", model);
        }

        public ActionResult DeleteStaff(int IntStaffID)
        {
            Staff remStaff = new Staff
            {
                IntStaffID = IntStaffID
            };

            bool success = StaffDAL.DeleteStaff(remStaff);

            StaffVM model = new StaffVM()
            {
                LstStaff = StaffDAL.GetAllStaff()
            };

            return PartialView("CRUDPartials/_Staff", model);
        }

        public ActionResult UpdateStaff(int IntStaffID, int IntMemberID)
        {
            Staff upStaff = new Staff
            {
                IntStaffID = IntStaffID,
                IntMemberID = IntMemberID
            };

            bool success = StaffDAL.UpdateStaff(upStaff);

            StaffVM model = new StaffVM()
            {
                LstStaff = StaffDAL.GetAllStaff()
            };

            return PartialView("CRUDPartials/_Staff", model);
        }

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