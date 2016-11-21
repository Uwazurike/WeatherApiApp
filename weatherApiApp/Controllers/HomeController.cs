using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using weatherApiApp.Models;

namespace weatherApiApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View("weather2");
        }

        public JsonResult GetWeather()
        {
            WeatherClass myWeather = new WeatherClass();
            return Json(myWeather.GetCurrentWeather(), JsonRequestBehavior.AllowGet);
        }
    }
}