using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjektPIN.Startup))]
namespace ProjektPIN
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
