using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_04从mvc的角度讲解如何通过UrlRoutingModule截获aspnet管道流.Startup))]
namespace _04从mvc的角度讲解如何通过UrlRoutingModule截获aspnet管道流
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
