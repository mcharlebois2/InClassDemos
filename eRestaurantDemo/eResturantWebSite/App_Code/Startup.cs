using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(eResturantWebSite.Startup))]
namespace eResturantWebSite
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
