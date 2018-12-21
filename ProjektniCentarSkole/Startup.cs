using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjektniCentarSkole.Startup))]
namespace ProjektniCentarSkole
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
