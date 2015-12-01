using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(InClass1109.Startup))]
namespace InClass1109
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
