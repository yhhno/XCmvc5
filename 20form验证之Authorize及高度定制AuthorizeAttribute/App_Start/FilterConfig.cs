using System.Web;
using System.Web.Mvc;

namespace _20form验证之Authorize及高度定制AuthorizeAttribute
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
