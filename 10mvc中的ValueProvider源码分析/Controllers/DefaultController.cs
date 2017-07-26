using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _10mvc中的ValueProvider源码分析.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ValueProviderWithRouteData ()
        {
             var data =new RouteDataValueProviderFactory().GetValueProvider(ControllerContext);
             return View(new ShowData() { type = "RouteData", Value = data.ToString() });   
        }
        public ActionResult ValueProviderWithQueryString()
        {
            //var data = new QueryStringValueProviderFactory().GetValueProvider(ControllerContext);
            return View(new ShowData() { type = "QueryString", Value = ValueProvider.GetValue("id").RawValue.ToString() }); 
        }
        public ActionResult ValueProviderWithChildAction()
        {
            //var data = new ChildActionValueProviderFactory().GetValueProvider(ControllerContext);
            return View(new ShowData() { type = "ChildAction", Value = ValueProvider.GetValue("id").RawValue.ToString() });
        }

        public ActionResult ModelBinder(Student student)
        {
            ViewBag.Name = student.name;
            return View();
        }
    }

    public class ShowData
    {
        public string type { get; set; }
        public string Value { get; set; }
    }
    public class Student
    {
        public string name { get; set; }
    }
}