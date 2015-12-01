using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BandSite.Startup))]
namespace BandSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
