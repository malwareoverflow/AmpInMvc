using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AMPMvc.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //Redirect AMP Page if Mobile
            if (Request.Browser.IsMobileDevice)
            {
                return Redirect("/Amp/Index");
            }
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
    }
}