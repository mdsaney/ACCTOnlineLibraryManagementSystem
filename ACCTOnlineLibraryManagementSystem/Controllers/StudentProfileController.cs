using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ACCTOnlineLibraryManagementSystem.Models;

namespace ACCTOnlineLibraryManagementSystem.Controllers
{
    public class StudentProfileController : Controller
    {
        private ACCTOnlineLibraryEntities1 db = new ACCTOnlineLibraryEntities1();

        // GET: StudentProfile
        public ActionResult Index()
        {
           
           
                return View(db.Students.ToList());

           
        }

        public ActionResult StudentProfile()
        {
            if (Session["StudentID"] != null)
            {
                return View();

            }
            else
            {
                RedirectToAction("StudentLogIn", "Account");
            }

            return View();
        }


    }
}