using System;
using System.Web.Mvc;

namespace AVTestApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var timeUtc = DateTime.UtcNow;
            TimeZoneInfo easternZone = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time");
            var localDateTime = TimeZoneInfo.ConvertTimeFromUtc(timeUtc, easternZone);
            ViewBag.CurrentTime = localDateTime.ToShortTimeString();
            ViewBag.CurrentDate = localDateTime.ToShortDateString();

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