using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace _12跨越Session实现一个自定义的TempData源码分析
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            ControllerBuilder.Current.SetControllerFactory(typeof(MyControllerFactory));
        }
    }

    public class MyControllerFactory : DefaultControllerFactory
    {
        public override IController CreateController(RequestContext requestContext, string controllerName)
        {
            var iController = base.CreateController(requestContext, controllerName);

            var controller = iController as Controller;

            //这里就是我们的插入点
            controller.TempDataProvider = new CacheStateTempdata();

            return iController;
        }
    }

    public class CacheStateTempdata : ITempDataProvider
    {
        internal const string TempDataSessionStateKey = "__ControllerTempData";

        public virtual IDictionary<string, object> LoadTempData(ControllerContext controllerContext)
        {
            var cache = controllerContext.HttpContext.Cache;
            if (cache != null)
            {
                Dictionary<string, object> dictionary = cache["__ControllerTempData"] as Dictionary<string, object>;
                if (dictionary != null)
                {
                    cache.Remove("__ControllerTempData");
                    return dictionary;
                }
            }
            return new Dictionary<string, object>(StringComparer.OrdinalIgnoreCase);
        }

        public virtual void SaveTempData(ControllerContext controllerContext, IDictionary<string, object> values)
        {
            if (controllerContext == null)
            {
                throw new ArgumentNullException("controllerContext");
            }
            var cache = controllerContext.HttpContext.Cache;
            bool flag = (values != null) && (values.Count > 0);
            if (cache == null)
            {
                if (flag)
                {
                    throw new Exception("");
                }
            }
            else if (flag)
            {
                cache["__ControllerTempData"] = values;
            }
            else if (cache["__ControllerTempData"] != null)
            {
                cache.Remove("__ControllerTempData");
            }
        }
    }
}
