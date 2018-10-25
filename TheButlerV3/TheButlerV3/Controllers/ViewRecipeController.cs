using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TheButlerV3.Controllers
{
    public class ViewRecipeController : Controller
    {
        // GET: ViewRecipe
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Recipe(int r_ID)
        {
            r_ID = 0;
            return View(r_ID);
        }
    }
}