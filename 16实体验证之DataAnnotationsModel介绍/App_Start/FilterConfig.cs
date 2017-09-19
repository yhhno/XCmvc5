using System.Web;
using System.Web.Mvc;

namespace _16实体验证之DataAnnotationsModel介绍
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
