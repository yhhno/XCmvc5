using System.Web;
using System.Web.Mvc;

namespace _05从源码角度讲解MVC的Route以及如何自定义IRouteConstraint约束
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
