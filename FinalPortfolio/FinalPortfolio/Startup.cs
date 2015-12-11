using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FinalPortfolio.Startup))]
namespace FinalPortfolio
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
