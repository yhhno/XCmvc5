using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_20form验证之Authorize及高度定制AuthorizeAttribute.Startup))]
namespace _20form验证之Authorize及高度定制AuthorizeAttribute
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
