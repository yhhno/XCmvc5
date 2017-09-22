using System.Web;
using System.Web.Mvc;

namespace _24owin简介及常用microsoft.owin.xxx组件介绍
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
