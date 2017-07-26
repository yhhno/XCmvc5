using System.Web;
using System.Web.Mvc;

namespace _11从源码角度对ViewData和ViewBag以及TempData原理解析
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
