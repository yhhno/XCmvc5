using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_18Controller之IActionFilter拦截器分析.Startup))]
namespace _18Controller之IActionFilter拦截器分析
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
