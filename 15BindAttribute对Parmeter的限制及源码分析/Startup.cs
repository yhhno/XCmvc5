using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_15BindAttribute对Parmeter的限制及源码分析.Startup))]
namespace _15BindAttribute对Parmeter的限制及源码分析
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
