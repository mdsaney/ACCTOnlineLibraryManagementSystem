using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ACCTOnlineLibraryManagementSystem.Models;

namespace ACCTOnlineLibraryManagementSystem.Controllers
{
    public class FacultyProfileController : Controller
    {

        private ACCTOnlineLibraryEntities1 db = new ACCTOnlineLibraryEntities1();

        // GET: FacultyProfile
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult FacultyProfile()
        {
            try
            {
                if (Session["FacultyID"] != null)
                {
                    return View();

                }
                else
                {
                    RedirectToAction("StudentLogIn", "Account");
                }
            }
            catch (Exception ex)
            {
                

            }

            return View();

        }


    }

}