using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace _05从源码角度讲解MVC的Route以及如何自定义IRouteConstraint约束
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                constraints: new  { id=new myRout()}
                  //constraints: new  { id=@"\d+")}//正则表达式方式限定id为整数
            );
        }
    }

   public class myRout:IRouteConstraint{

       public bool Match(HttpContextBase httpContext, Route route, string parameterName, RouteValueDictionary values, RouteDirection routeDirection)
       {
           var id = values[parameterName];
           return true;
       }
   }
}
