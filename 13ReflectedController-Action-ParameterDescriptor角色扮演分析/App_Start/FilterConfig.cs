using System.Web;
using System.Web.Mvc;

namespace _13ReflectedController_Action_ParameterDescriptor角色扮演分析
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
