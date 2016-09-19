using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Recipe()
        {
            ViewBag.Message = "Recipe";

            return View();
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Contact";

            return View();
        }

        public ActionResult Gallery()
        {
            ViewBag.Message = "Gallery";

            return View();
        }
    }
}