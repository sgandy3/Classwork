using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(InClass1110.Startup))]
namespace InClass1110
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
