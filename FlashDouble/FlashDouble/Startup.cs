using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FlashDouble.Startup))]
namespace FlashDouble
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
