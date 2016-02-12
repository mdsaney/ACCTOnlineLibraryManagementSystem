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
        public ActionResult StudentRegistration()
        {
            return View();
        }

        [HttpPost]
        public ActionResult StudentRegistration(Models.Student student)
        {

            if (ModelState.IsValid)
            {
                using (var db = new ACCTOnlineLibraryEntities1())
                {

                    var sysUser = db.Students.Create();

                    if (IsExist((student.RegID)))
                    {
                        ModelState.AddModelError("", "Error Field ");
                    }
                    else
                    {

                        sysUser.RegID = student.RegID;
                        sysUser.StudentName = student.StudentName;
                        sysUser.Department = student.Department;
                        sysUser.Email = student.Email;
                        sysUser.Password = student.Password;
                        sysUser.Contact = student.Contact;
                        sysUser.Address = student.Address;

                        db.Students.Add(sysUser);
                        db.SaveChanges();

                        return RedirectToAction("Success", "Account");

                    }

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
        public ActionResult StudentLogIn(Student student)
        {
           using (ACCTOnlineLibraryEntities1 db = new ACCTOnlineLibraryEntities1())
           {
               var user = db.Students.Single(s => s.Email == student.Email && s.Password == student.Password);

                if (user != null)
                {
                    Session["StudentID"] = user.StudentID.ToString();
                    Session["RegID"] = user.RegID.ToString();
                    Session["StudentName"] = user.StudentName;
                    Session["Department"] = user.Department;
                    Session["Email"] = user.Email;
                    Session["Password"] = user.Password;
                    Session["Contact"] = user.Contact.ToString();
                    Session["Address"] = user.Department;
                  


                    return RedirectToAction("StudentProfile", "StudentProfile");
                }
                else
                {
                    ModelState.AddModelError("", "Email and/or Password is wrong. Please try Again");
                }

            }


            return View();
        }


        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();

            return RedirectToAction("Index", "Account");
        }

        private ActionResult RedirectToLocal(string returnURL)
        {
            if (Url.IsLocalUrl(returnURL))
            {
                return Redirect(returnURL);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }



     

        public ActionResult Success()
        {

            return View();
        }


        public ActionResult LoginSuccess()
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


        [HttpGet]
        public ActionResult FacultyRegistration()
        {
            return View();
        }

        [HttpPost]
        public ActionResult FacultyRegistration(Models.Faculty faculty)
        {
            if (ModelState.IsValid)
            {
                using (var db = new ACCTOnlineLibraryEntities1())
                {

                    var facUser = db.Faculties.Create();

                    facUser.Name = faculty.Name;
                    facUser.Designation = faculty.Designation;
                    facUser.Department = faculty.Department;
                    facUser.Email = faculty.Email;
                    facUser.Password = faculty.Password;
                    facUser.Phone = faculty.Phone;
                    facUser.Address = faculty.Address;

                    db.Faculties.Add(facUser);
                    db.SaveChanges();

                    return RedirectToAction("Success", "Account");

                }
            }
            else
            {
                ModelState.AddModelError("", "Error Field ");
            }
            return View();
        }

        [HttpGet]
        public ActionResult FacultyLogIn()
        {
            return View();
        }

        [HttpPost]
        public ActionResult FacultyLogIn(Faculty faculty)
        {
            using (ACCTOnlineLibraryEntities1 db = new ACCTOnlineLibraryEntities1())
            {
                var user = db.Faculties.Single(f=> f.Email == faculty.Email && f.Password == faculty.Password);

                if (user != null)
                {
                    Session["FacultyID"] = user.FacultyID.ToString();
                    Session["Name"] = user.Name;
                    Session["Designation"] = user.Designation;
                    Session["Department"] = user.Department;
                    Session["Email"] = user.Email;
                    Session["Password"] = user.Password;
                    Session["Phone"] = user.Phone.ToString();
                    Session["Address"] = user.Department;

                    return RedirectToAction("FacultyProfile", "FacultyProfile");
                }
                else
                {
                    ModelState.AddModelError("", "Email and/or Password is wrong. Please try Again");
                }

            }


            return View();
        }



        public bool IsExist(string regId)
        {
            ACCTOnlineLibraryEntities1 db = new ACCTOnlineLibraryEntities1();
            bool exist = true;

            var student = db.Students.Find(regId);

            if (student ==null)
            {
                exist = false;
              
            }
         
                return exist;
            
        }
    }
}