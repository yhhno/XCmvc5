using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _06对众多ActionResult的深入源码分析_上_.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            //练习json
            ////其中背后的操作就是下面，JsonResult对其封装了下
            ////Response.ContentType = "application/json";
            ////Response.Write("json数据");

            //return Json(new { name = "fuck", age = 33 }, JsonRequestBehavior.DenyGet);

           //练习javascriptReuslt
            return View();
        }

        public ActionResult About()
        {
            //本质上还是封装了response.write();
            return JavaScript("var i='fuck';alert(i);");
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}