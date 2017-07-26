using System.Web;
using System.Web.Mvc;

namespace _08Razor视图基础结构以及ViewStart解析
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
