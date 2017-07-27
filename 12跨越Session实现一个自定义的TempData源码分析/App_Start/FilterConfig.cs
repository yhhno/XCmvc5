using System.Web;
using System.Web.Mvc;

namespace _12跨越Session实现一个自定义的TempData源码分析
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
