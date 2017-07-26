using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_10mvc中的ValueProvider源码分析.Startup))]
namespace _10mvc中的ValueProvider源码分析
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
