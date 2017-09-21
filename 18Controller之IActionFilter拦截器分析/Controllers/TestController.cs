using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _18Controller之IActionFilter拦截器分析.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        //[MyCustom]
        public ActionResult Index()
        {
            return View();
        }
        //protected override void OnActionExecuting(ActionExecutingContext filterContext)
        //{
        //    var actionName = filterContext.ActionDescriptor.ActionName;
        //    var controllerName = filterContext.ActionDescriptor.ControllerDescriptor.ControllerName;
        //    filterContext.HttpContext.Response.Write(controllerName + "_" + actionName);
        //    base.OnActionExecuting(filterContext);
        //}
        //protected override void OnActionExecuted(ActionExecutedContext filterContext)
        //{
        //    base.OnActionExecuted(filterContext);
        //}

    }
    public class MyCustomAttribute : FilterAttribute, IActionFilter
    {

        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            throw new NotImplementedException();
        }

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
           //1.如果result 不为空,就return,不执行递归...递归啥呢?
            filterContext.Result = new ViewResult()
            {
                ViewName = "Error"
            };
        }
    }
}