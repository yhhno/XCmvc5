using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_07对众多ActionResult的深入源码分析_下_.Startup))]
namespace _07对众多ActionResult的深入源码分析_下_
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
