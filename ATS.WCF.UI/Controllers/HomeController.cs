using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ATS.WCF.UI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var service = new ATSService.UserServiceClient();
            var name = service.GetUserName("Nitai");
            ViewBag.Message = "Welcome to ASP.NET MVC!";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}