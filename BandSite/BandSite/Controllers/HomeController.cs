using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BandSite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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

        public ActionResult Backstage()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Merch()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Shows()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}