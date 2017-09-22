using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _23Area在mvc中的使用以及架构思想.Areas.Hotel.Controllers
{
    public class HomeController : Controller
    {
        // GET: Hotel/Home
        public ActionResult Index()
        {
            return View();
        }
    }
}