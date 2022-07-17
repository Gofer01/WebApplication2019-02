using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebApplication2019_02.Startup))]
namespace WebApplication2019_02
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
