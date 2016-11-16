using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Home4Us.Startup))]
namespace Home4Us
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
