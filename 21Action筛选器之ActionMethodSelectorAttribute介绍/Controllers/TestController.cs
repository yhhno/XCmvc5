using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _21Action筛选器之ActionMethodSelectorAttribute介绍.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        //[HttpGet]
        //[AcceptVerbs(HttpVerbs.Get)]
        [MyActionMethodSelector]
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string username, string password)
        {
            return View();
        }
    }

    public class MyActionMethodSelectorAttribute:ActionMethodSelectorAttribute
    {
        public override bool IsValidForRequest(ControllerContext controllerContext, System.Reflection.MethodInfo methodInfo)
        {
            var HttpMethodOverride = controllerContext.HttpContext.Request.GetHttpMethodOverride();
            var IsAjax = controllerContext.HttpContext.Request.IsAjaxRequest();
            return HttpMethodOverride.ToLower() == "get" && IsAjax;

        }
    }
}