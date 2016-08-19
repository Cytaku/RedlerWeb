using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RedlerWeb.Startup))]
namespace RedlerWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
