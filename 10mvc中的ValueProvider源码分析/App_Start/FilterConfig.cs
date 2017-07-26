using System.Web;
using System.Web.Mvc;

namespace _10mvc中的ValueProvider源码分析
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
