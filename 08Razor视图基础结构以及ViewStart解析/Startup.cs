using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_08Razor视图基础结构以及ViewStart解析.Startup))]
namespace _08Razor视图基础结构以及ViewStart解析
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
