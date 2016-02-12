using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ACCTOnlineLibraryManagementSystem.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string searchString)
        {
            var db = new ACCTOnlineLibraryEntities1();
            
                var books = from book in db.Books
                    select book;

                if (!string.IsNullOrEmpty(searchString))
                {
                    books = books.Where(b => b.BookTitle.Contains(searchString));

                }

            

            return View(books);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}