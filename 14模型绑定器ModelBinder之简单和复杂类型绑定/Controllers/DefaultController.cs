using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _14模型绑定器ModelBinder之简单和复杂类型绑定.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index(student stu)
        {

            return View();
        }
    }

    public class student
    {
        public string name { get; set; }
        public int age { get; set; }
        public address add { get; set; }
       
    }
    public class address
    {
        public string city { get; set; }
    }
}