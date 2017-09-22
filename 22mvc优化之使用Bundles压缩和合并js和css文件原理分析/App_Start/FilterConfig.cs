using System.Web;
using System.Web.Mvc;

namespace _22mvc优化之使用Bundles压缩和合并js和css文件原理分析
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
