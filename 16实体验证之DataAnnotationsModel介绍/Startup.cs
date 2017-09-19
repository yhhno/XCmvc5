using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_16实体验证之DataAnnotationsModel介绍.Startup))]
namespace _16实体验证之DataAnnotationsModel介绍
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
