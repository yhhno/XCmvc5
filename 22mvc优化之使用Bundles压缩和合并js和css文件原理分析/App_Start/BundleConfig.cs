using System.Web;
using System.Web.Optimization;

namespace _22mvc优化之使用Bundles压缩和合并js和css文件原理分析
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            //bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
            //            "~/Scripts/jquery-{version}.js"));

            //bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
            //            "~/Scripts/jquery.validate*"));

            //// Use the development version of Modernizr to develop with and learn from. Then, when you're
            //// ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            //bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
            //            "~/Scripts/modernizr-*"));

            //bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
            //          "~/Scripts/bootstrap.js",
            //          "~/Scripts/respond.js"));

            //bundles.Add(new StyleBundle("~/Content/css").Include(
            //          "~/Content/bootstrap.css",
            //          "~/Content/site.css"));

            var scriptBundle = new ScriptBundle("~/bundle/test").Include("~/Scripts/1.js", "~/Scripts/2.js");
            bundles.Add(scriptBundle);

            //虚拟路径和真实路径的映射关系? 为啥要有虚拟路径呢?

            //指定优化压缩
            BundleTable.EnableOptimizations = true;
        }
    }
}
