using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_13ReflectedController_Action_ParameterDescriptor角色扮演分析.Startup))]
namespace _13ReflectedController_Action_ParameterDescriptor角色扮演分析
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
