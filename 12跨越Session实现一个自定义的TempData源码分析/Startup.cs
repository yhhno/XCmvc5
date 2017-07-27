using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_12跨越Session实现一个自定义的TempData源码分析.Startup))]
namespace _12跨越Session实现一个自定义的TempData源码分析
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
