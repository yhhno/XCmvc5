using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_05从源码角度讲解MVC的Route以及如何自定义IRouteConstraint约束.Startup))]
namespace _05从源码角度讲解MVC的Route以及如何自定义IRouteConstraint约束
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
