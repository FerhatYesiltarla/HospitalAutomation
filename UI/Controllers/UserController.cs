using DAL.ORM.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UI.Security.Authentication;
using UI.Service;

namespace UI.Controllers
{
    public class UserController : Controller
    {
        /* [Authorize(Roles = "1")] */
        public ActionResult Main()
        {
            return View();
        }

        [RestrictToAjax]
        [HttpPost]
        public ActionResult Hospitals()
        {
            List<Hospital> hospitals = null;

            if (ModelState.IsValid)
            {
                hospitals = DataService.Service.HospitalService.SelectAll();
            }

            return View(hospitals);
        }

        [HttpPost]
        public ActionResult Policlinics()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Doctors()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Patients()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Appointments()
        {
            return View();
        }
    }
}