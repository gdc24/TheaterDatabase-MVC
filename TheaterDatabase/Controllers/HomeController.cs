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

            IEnumerable<Cast> allCasts = CastsDAL.GetAllCasts();
            IEnumerable<Club> allClubs = ClubsDAL.GetAllClubs();
            IEnumerable<Date> allDates = DatesDAL.GetAllDates();
            IEnumerable<Exec> allExec = ExecDAL.GetAllExec();
            IEnumerable<Member> allMembers = MembersDAL.GetAllMembers();
            IEnumerable<Pit> allPits = PitsDAL.GetAllPits();
            IEnumerable<Show> allShows = ShowsDAL.GetAllShows();
            IEnumerable<Staff> allStaff = StaffDAL.GetAllStaff();



            model._casts_vm.LstCasts = allCasts;
            model._casts_vm.LstAllMembers = allMembers;
            model._casts_vm.LstAllShows = allShows;

            model._exec_vm.LstExec = allExec;
            model._exec_vm.LstAllMembers = allMembers;
            model._exec_vm.LstAllClubs = allClubs;
            model._exec_vm.LstAllDates = allDates;

            model._members_vm.LstMembers = allMembers;

            model._pits_vm.LstPits = allPits;

            model._shows_vm.LstShows = allShows;
            model._shows_vm.LstAllClubs = allClubs;

            model._staff_vm.LstStaff = allStaff;

            return View(model);
        }

        public ActionResult Analytics()
        {
            ViewBag.Message = "Analytics";

            return View();
        }

        #region REGION - CASTS

        public ActionResult InsertCasts(string StrVoicePart, string StrRole, int IntMemberID, int IntShowID)
        {
            Cast newCast = new Cast
            {
                StrVoicePart = StrVoicePart,
                StrRole = StrRole,
                IntMemberID = IntMemberID,
                Member = MembersDAL.GetMember(IntMemberID),
                IntShowID = IntShowID,
                Show = ShowsDAL.GetShow(IntShowID)
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
            Cast upCast = new Cast
            {
                IntCastID = IntCastID,
                IntMemberID = IntMemberID,
                Member = MembersDAL.GetMember(IntMemberID)
            };

            bool success = CastsDAL.UpdateCast(upCast);

            CastsVM model = new CastsVM()
            {
                LstCasts = CastsDAL.GetAllCasts(),
                LstAllMembers = MembersDAL.GetAllMembers(),
                LstAllShows = ShowsDAL.GetAllShows()
            };

            return PartialView("CRUDPartials/_Casts", model);
        }

        #endregion

        #region REGION - CLUBS

        public void InsertClubs(string StrClubName, string StrAdvisor, string StrUmbrellaOrg, UmbrellaOrg umbrellaOrg)
        {
            Club newClub = new Club
            {
                StrClubName = StrClubName,
                StrAdvisor = StrAdvisor,
                StrUmbrellaOrg = StrUmbrellaOrg,
                UmbrellaOrg = umbrellaOrg
            };

            bool success = ClubsDAL.InsertClub(newClub);
        }

        public void DeleteClubs(int IntClubID)
        {
            Club remClub = new Club
            {
                IntClubID = IntClubID
            };

            bool success = ClubsDAL.DeleteClub(remClub);
        }

        public void UpdateClubs(int IntClubID, string StrClubName, string StrAdvisor, string StrUmbrellaOrg, UmbrellaOrg umbrellaOrg)
        {
            Club upClup = new Club
            {
                IntClubID = IntClubID,
                StrClubName = StrClubName,
                StrAdvisor = StrAdvisor,
                StrUmbrellaOrg = StrUmbrellaOrg,
                UmbrellaOrg = umbrellaOrg
            };

            bool success = ClubsDAL.UpdateClub(upClup);
        }

        #endregion

        #region REGION - DATES

        public void InsertDates(string StrSemester, Semester semester, int IntYear)
        {
            Date newDate = new Date
            {
                StrSemester = StrSemester,
                Semester = semester,
                IntYear = IntYear
            };

            bool success = DatesDAL.InsertDate(newDate);
        }

        public void DeleteDates(int IntDateID)
        {
            Date remDate = new Date
            {
                IntDateID = IntDateID
            };

            bool success = DatesDAL.DeleteDate(remDate);
        }


        public void UpdateDates(int IntDateID, string StrSemester, Semester semester, int IntYear)
        {
            Date upDate = new Date
            {
                IntDateID = IntDateID,
                StrSemester = StrSemester,
                Semester = semester,
                IntYear = IntYear
            };

            bool success = DatesDAL.UpdateDate(upDate);
        }

        #endregion

        #region REGION - EXEC

        public ActionResult InsertExec(string StrPosition, int IntMemberID, int IntDateID, int IntClubID)
        {
            Exec newExec = new Exec
            {
                StrPosition = StrPosition,
                IntMemberID = IntMemberID,
                Member = MembersDAL.GetMember(IntMemberID),
                IntDateID = IntDateID,
                Date = DatesDAL.GetDate(IntDateID),
                IntClubID = IntClubID,
                Club = ClubsDAL.GetClub(IntClubID)
            };

            bool success = ExecDAL.InsertExec(newExec);

            ExecVM model = new ExecVM()
            {
                LstExec = ExecDAL.GetAllExec()
            };

            return PartialView("CRUDPartials/_Exec", model);
        }

        public ActionResult DeleteExec(int IntExecID)
        {
            Exec remExec = new Exec
            {
                IntExecID = IntExecID
            };

            bool success = ExecDAL.DeleteExec(remExec);

            ExecVM model = new ExecVM()
            {
                LstExec = ExecDAL.GetAllExec()
            };

            return PartialView("CRUDPartials/_Exec", model);
        }

        public ActionResult UpdateExec(int IntExecID, int IntMemberID)
        {
            Exec upExec = new Exec
            {
                IntExecID = IntExecID,
                IntMemberID = IntMemberID,
                Member = MembersDAL.GetMember(IntMemberID)
            };

            bool success = ExecDAL.UpdateExec(upExec);

            ExecVM model = new ExecVM()
            {
                LstExec = ExecDAL.GetAllExec()
            };

            return PartialView("CRUDPartials/_Exec", model);
        }

        #endregion

        #region REGION - MEMBERS

        public ActionResult InsertMembers(string StrName)
        {
            Member newMember = new Member
            {
                StrName = StrName
            };

            bool success = MembersDAL.InsertMember(newMember);

            MembersVM model = new MembersVM()
            {
                LstMembers = MembersDAL.GetAllMembers()
            };

            return PartialView("CRUDPartials/_Members", model);
        }

        public ActionResult DeleteMembers(int IntMemberID)
        {
            Member remMember = new Member
            {
                IntMemberID = IntMemberID
            };

            bool success = MembersDAL.DeleteMember(remMember);

            MembersVM model = new MembersVM()
            {
                LstMembers = MembersDAL.GetAllMembers()
            };

            return PartialView("CRUDPartials/_Members", model);
        }

        public ActionResult UpdateMembers(int IntMemberID, string StrName)
        {
            Member upMember = new Member
            {
                IntMemberID = IntMemberID,
                StrName = StrName
            };

            bool success = MembersDAL.UpdateMember(upMember);

            MembersVM model = new MembersVM()
            {
                LstMembers = MembersDAL.GetAllMembers()
            };

            return PartialView("CRUDPartials/_Members", model);
        }

        #endregion

        #region REGION - PITS

        public ActionResult InsertPits(string StrInstrument, int IntSeat, int IntMemberID, int IntShowID)
        {
            Pit newPit = new Pit
            {
                StrInstrument = StrInstrument,
                IntSeat = IntSeat,
                IntMemberID = IntMemberID,
                Member = MembersDAL.GetMember(IntMemberID),
                IntShowID = IntShowID,
                Show = ShowsDAL.GetShow(IntShowID)
            };

            bool success = PitsDAL.InsertPit(newPit);

            PitsVM model = new PitsVM()
            {
                LstPits = PitsDAL.GetAllPits()
            };

            return PartialView("CRUDPartials/_Pits", model);
        }

        public ActionResult DeletePits(int IntPitID)
        {
            Pit remPit = new Pit
            {
                IntPitID = IntPitID
            };

            bool success = PitsDAL.DeletePit(remPit);

            PitsVM model = new PitsVM()
            {
                LstPits = PitsDAL.GetAllPits()
            };

            return PartialView("CRUDPartials/_Pits", model);
        }

        public ActionResult UpdatePits(int IntPitID, int IntMemberID)
        {
            Pit upPit = new Pit
            {
                IntPitID = IntPitID,
                IntMemberID = IntMemberID,
                Member = MembersDAL.GetMember(IntMemberID)
            };

            bool success = PitsDAL.UpdatePit(upPit);

            PitsVM model = new PitsVM()
            {
                LstPits = PitsDAL.GetAllPits()
            };

            return PartialView("CRUDPartials/_Pits", model);
        }

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

        //public ActionResult InsertCasts(string StrVoicePart, string StrRole, int IntMemberID, int IntShowID)
        //{
        //    Cast newCast = new Cast
        //    {
        //        StrVoicePart = StrVoicePart,
        //        StrRole = StrRole,
        //        IntMemberID = IntMemberID,
        //        IntShowID = IntShowID
        //    };

        //    bool success = CastsDAL.InsertCast(newCast);

        //    CastsVM model = new CastsVM()
        //    {
        //        LstCasts = CastsDAL.GetAllCasts(),
        //        LstAllMembers = MembersDAL.GetAllMembers(),
        //        LstAllShows = ShowsDAL.GetAllShows()
        //    };


        //    return PartialView("CRUDPartials/_Casts", model);

        //}

        //public ActionResult DeleteCasts(int IntCastID)
        //{
        //    Cast remCast = new Cast
        //    {
        //        IntCastID = IntCastID
        //    };

        //    bool success = CastsDAL.DeleteCast(remCast);

        //    CastsVM model = new CastsVM()
        //    {
        //        LstCasts = CastsDAL.GetAllCasts(),
        //        LstAllMembers = MembersDAL.GetAllMembers(),
        //        LstAllShows = ShowsDAL.GetAllShows()
        //    };


        //    return PartialView("CRUDPartials/_Casts", model);

        //}

        //public ActionResult UpdateCasts(int IntCastID, int IntMemberID)
        //{
        //    Cast updCast = new Cast
        //    {
        //        IntCastID = IntCastID,
        //        IntMemberID = IntMemberID
        //    };

        //    bool success = CastsDAL.UpdateCast(updCast);

        //    CastsVM model = new CastsVM()
        //    {
        //        LstCasts = CastsDAL.GetAllCasts(),
        //        LstAllMembers = MembersDAL.GetAllMembers(),
        //        LstAllShows = ShowsDAL.GetAllShows()
        //    };


        //    return PartialView("CRUDPartials/_Casts", model);

        //}

        #endregion
    }
}