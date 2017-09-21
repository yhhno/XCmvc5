using _18Controller之IActionFilter拦截器分析.Controllers;
using System.Web;
using System.Web.Mvc;

namespace _18Controller之IActionFilter拦截器分析
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new MyCustomAttribute());
        }
    }
}
