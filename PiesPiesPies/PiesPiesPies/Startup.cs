using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PiesPiesPies.Startup))]
namespace PiesPiesPies
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
