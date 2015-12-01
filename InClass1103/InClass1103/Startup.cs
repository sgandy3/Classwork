using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(InClass1103.Startup))]
namespace InClass1103
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
