using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_24owin简介及常用microsoft.owin.xxx组件介绍.Startup))]
namespace _24owin简介及常用microsoft.owin.xxx组件介绍
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            
        }
    }
}
