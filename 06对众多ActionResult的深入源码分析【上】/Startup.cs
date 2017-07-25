using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_06对众多ActionResult的深入源码分析_上_.Startup))]
namespace _06对众多ActionResult的深入源码分析_上_
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
