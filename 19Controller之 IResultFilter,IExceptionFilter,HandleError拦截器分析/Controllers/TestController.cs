using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _19Controller之_IResultFilter_IExceptionFilter_HandleError拦截器分析.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
     
            [MyHandleError]
        public ActionResult Index()
        {
            throw new Exception("");
            return View();
        }

        //protected override void OnResultExecuting(ResultExecutingContext filterContext)
        //{
        //    base.OnResultExecuting(filterContext);
        //}

        //protected override void OnResultExecuted(ResultExecutedContext filterContext)
        //{
        //    base.OnResultExecuted(filterContext);
        //}

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }

    public class MyHandleErrorAttribute : FilterAttribute, IExceptionFilter// HandleErrorAttribute
    {
        public void OnException(ExceptionContext filterContext)
        {
            //记录日志。。。。my logic
            filterContext.ExceptionHandled = true;

            //base.OnException(filterContext);
        }
    }

    //public class MyActionFilterAttribute : ActionFilterAttribute
    //{
    //    public override void OnResultExecuting(ResultExecutingContext filterContext)
    //    {
    //        base.OnResultExecuting(filterContext);
    //    }

    //    public override void OnResultExecuted(ResultExecutedContext filterContext)
    //    {
    //        base.OnResultExecuted(filterContext);
    //    }
    //}
}