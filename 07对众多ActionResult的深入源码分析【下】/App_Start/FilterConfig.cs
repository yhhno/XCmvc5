using System.Web;
using System.Web.Mvc;

namespace _07对众多ActionResult的深入源码分析_下_
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
