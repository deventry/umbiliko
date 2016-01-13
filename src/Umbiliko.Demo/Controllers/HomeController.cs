using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbiliko.Web.Constants;
using Umbiliko.Web.Mvc;

namespace Umbiliko.Demo.Controllers
{
    [Feature("demo"), RoutePrefix("")]
    public class HomeController : Controller
    {
        [Activity("home", Level = AccessLevels.Public)]
        public ActionResult Index()
        {
            return View();
        }

        [Activity("about", Level = AccessLevels.Public), Route("about")]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [Activity("contact", Level = AccessLevels.Public), Route("contact")]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [Activity("dashboard", Level = AccessLevels.Alleged), Route("dashboard")]
        public ActionResult Dashboard()
        {
            ViewBag.Message = "Your personal info.";

            return View();
        }
    }
}