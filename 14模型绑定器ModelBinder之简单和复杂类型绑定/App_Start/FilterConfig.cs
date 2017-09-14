using System.Web;
using System.Web.Mvc;

namespace _14模型绑定器ModelBinder之简单和复杂类型绑定
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
