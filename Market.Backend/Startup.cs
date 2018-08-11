using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Market.Backend.Startup))]
namespace Market.Backend
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
