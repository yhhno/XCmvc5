using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_21Action筛选器之ActionMethodSelectorAttribute介绍.Startup))]
namespace _21Action筛选器之ActionMethodSelectorAttribute介绍
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
