using System.Web;
using System.Web.Mvc;

namespace _04从mvc的角度讲解如何通过UrlRoutingModule截获aspnet管道流
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
