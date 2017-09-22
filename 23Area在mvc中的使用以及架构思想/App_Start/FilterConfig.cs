using System.Web;
using System.Web.Mvc;

namespace _23Area在mvc中的使用以及架构思想
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
