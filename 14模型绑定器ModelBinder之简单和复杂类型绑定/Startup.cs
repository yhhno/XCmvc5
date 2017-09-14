using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_14模型绑定器ModelBinder之简单和复杂类型绑定.Startup))]
namespace _14模型绑定器ModelBinder之简单和复杂类型绑定
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
