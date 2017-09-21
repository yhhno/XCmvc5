using System.Web;
using System.Web.Mvc;

namespace _19Controller之_IResultFilter_IExceptionFilter_HandleError拦截器分析
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
