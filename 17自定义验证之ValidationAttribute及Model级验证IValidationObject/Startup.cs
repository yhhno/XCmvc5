using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_17自定义验证之ValidationAttribute及Model级验证IValidationObject.Startup))]
namespace _17自定义验证之ValidationAttribute及Model级验证IValidationObject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
