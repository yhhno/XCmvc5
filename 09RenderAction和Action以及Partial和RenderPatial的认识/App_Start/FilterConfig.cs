using System.Web;
using System.Web.Mvc;

namespace _09RenderAction和Action以及Partial和RenderPatial的认识
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
