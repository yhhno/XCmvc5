using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _11从源码角度对ViewData和ViewBag以及TempData原理解析.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            ViewData.Add("username", "fucker");

            ViewBag.Username = "Motherfucker";
            return View();
        }

        public ActionResult TempDataSet()
        {
            TempData["Temp"] = "See you";
            return View();
        }

        public ActionResult TempDataGet()
        {
            ViewBag.IsNull = TempData["Temp"] == null ? false : true;
            ViewBag.Value = TempData["Temp"];
            return View();
        }
    }
}