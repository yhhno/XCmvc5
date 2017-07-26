using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_11从源码角度对ViewData和ViewBag以及TempData原理解析.Startup))]
namespace _11从源码角度对ViewData和ViewBag以及TempData原理解析
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
