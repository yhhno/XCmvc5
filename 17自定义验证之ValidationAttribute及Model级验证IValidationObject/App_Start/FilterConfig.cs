using System.Web;
using System.Web.Mvc;

namespace _17自定义验证之ValidationAttribute及Model级验证IValidationObject
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
