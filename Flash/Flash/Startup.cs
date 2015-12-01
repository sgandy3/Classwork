using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Flash.Startup))]
namespace Flash
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
