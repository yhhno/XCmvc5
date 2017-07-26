using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _09RenderAction和Action以及Partial和RenderPatial的认识.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View(new Student() { name="西瓜"});
        }

        [ChildActionOnly]
        public ActionResult Login()
        {
            return PartialView();
        }

        [ChildActionOnly]
        public ActionResult LoginWithId(int? id)
        {
            //可以添加自己的业务逻辑
            if (id>10)
            {
                id = id + 100;
            }

            ViewBag.id = id;
            ViewData["Id"] = id;
            return PartialView();
        }
    }

    public class Student
    {
        public string name { get; set; }
    }
}