using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SOSWebApp.Startup))]
namespace SOSWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
