using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _15BindAttribute对Parmeter的限制及源码分析.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            return View(new student() { id=1,name="jack",age=22});
        }

        [HttpPost]
        //public ActionResult Index([Bind(Include = "age,name")]student str)
         //public ActionResult Index([Bind(Prefix="s")]student str)
        public ActionResult Index(student str)       
        {
            return View();
        }
    }

    public class student
    {
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
    }
}