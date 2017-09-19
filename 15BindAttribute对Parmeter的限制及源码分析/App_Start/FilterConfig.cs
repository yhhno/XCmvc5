using System.Web;
using System.Web.Mvc;

namespace _15BindAttribute对Parmeter的限制及源码分析
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
