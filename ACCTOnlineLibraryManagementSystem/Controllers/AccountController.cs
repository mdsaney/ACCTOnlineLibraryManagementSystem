using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using ACCTOnlineLibraryManagementSystem.Models;


namespace ACCTOnlineLibraryManagementSystem.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Registration()
        {
            return View();
        }



        [HttpGet]
        public ActionResult FacultyLogIn()
        {
            return View();
        }

        [HttpPost]
        public ActionResult FacultyLogIn(Models.FacultyLoginModel FUser)
        {
            if (ModelState.IsValid)
            {
                if (IsValid(FUser.FUserName, FUser.Password))
                {
                    FormsAuthentication.SetAuthCookie(FUser.FUserName, false);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Login Data is Incorrect..");
                }

            }


            return View();
        }

        [HttpGet]
        public ActionResult StudentLogIn()
        {
            return View();
        }

        [HttpPost]
        public ActionResult StudentLogIn(Models.StudentLogin User)
        {
            if (ModelState.IsValid)
            {
                if (IsStudentValid(User.UserName, User.Password))
                {
                    FormsAuthentication.SetAuthCookie(User.UserName, false);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Login Data is Incorrect..");
                }

            }


            return View();
        }


        [HttpGet]
        public ActionResult StudentRegistration()
        {
           return View();
        }

        [HttpPost]
        public ActionResult StudentRegistration(Models.Student student)
        {
            if (ModelState.IsValid)
            {
                using (var db = new ACCTOnlineLibraryEntities())
                {
                   
                    var sysUser = db.Students.Create();

                   
                    sysUser.StudentName = student.StudentName;
                    sysUser.Department = student.Department;
                    sysUser.Email = student.Email;
                    sysUser.Contact = student.Contact;
                    sysUser.Address = student.Address;
                    sysUser.MemberSince = DateTime.Now;


                    db.Students.Add(sysUser);
                    db.SaveChanges();

                    return RedirectToAction("Index", "Home");

                }
            }
            else
            {
                ModelState.AddModelError("", "Error Field ");
            }

            return View();
        }





        [HttpGet]
        public ActionResult FacultyRegistration()
        {

            return View();
        }










        private bool IsValid(string fuser, string pass)
        {
            bool isValid = false;
            

            using (var db = new ACCTOnlineLibraryEntities())
            {
                var user = db.FacultyLogins.FirstOrDefault(u => u.FUserName == fuser);

                if (user != null)
                {
                    if (user.Password == pass)
                    {
                        isValid = true;

                    }
                }

            }

            return isValid;

        }


        private bool IsStudentValid(string suser, string pass)
        {
            bool isValid = false;


            using (var db = new ACCTOnlineLibraryEntities())
            {
                var user = db.StudentLogins.FirstOrDefault(u => u.UserName == suser);

                if (user != null)
                {
                    if (user.Password == pass)
                    {
                        isValid = true;

                    }
                }

            }

            return isValid;

        }







    }
}