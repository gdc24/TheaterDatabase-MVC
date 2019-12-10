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
            model._shows_vm.LstShows = ShowsDAL.GetAllShows();

            return View(model);
        }

        public ActionResult Analytics()
        {
            ViewBag.Message = "Analytics";

            return View();
        }

        #region REGION - SHOWS

        /*public ActionResult UpdateShows(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var employee = _context.Employees.SingleOrDefault(e => e.EmployeeId == id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }*/

        #endregion

        #region REGION - MEMBERS

        /*public ActionResult UpdateMembers(int? id)
        {
            if(id == null)
            {
                return new HTTPStatusCodeResult(HttpStatusCode.BadRequest);
            }

            return View();
        }*/

        #endregion

        #region REGION - DATES

        /*public ActionResult UpdateDates(int? id)
        {
            if(id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            return View();
        }*/

        #endregion

        #region REGION - PITS

        /*public ActionResult UpdatePits(int? id)
        {
            if(id==null)
            {
                return new HTTPStatusCodeResult(HttpStatusCode.BadRequest);
            }

            return View();
        }*/

        #endregion

        #region REGION - SHOWS

        /*public ActionResult UpdateShows(int? id)
        {
            if(id==null)
            {
                return new HTTPStatusCodeResult(HttpStatusCode.BadRequest);
            }

            return View();
        }*/

        #endregion

        #region REGION - STAFFS

        /*public ActionResult UpdateStaffs(int? id)
        {
            if(id==null)
            {
               return new HTTPStatusCodeResult(HttpStatusCode.BadRequest);
            }

            return View();
        }*/

        #endregion

        #region REGION - EXEC

        /*public ActionResult UpdateExec(int? id)
        {
            if(id==null)
            {
                return new HTTPStatusCodeResult(HttpStatusCode.BadRequest);
            }
        
            return View();
        }*/

        #endregion
    }
}