using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TheButlerV3.Models;

namespace TheButlerV3.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            return View ();
        }

        public ActionResult Recipe()
        {
            ViewBag.Message = "Your recipe page.";

            return View();
        }       
        public ActionResult UserPage()
        { 
            return View();
        }
    }
}