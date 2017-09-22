using System.Web;
using System.Web.Mvc;

namespace _21Action筛选器之ActionMethodSelectorAttribute介绍
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
