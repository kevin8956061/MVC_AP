using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_AP.Startup))]
namespace MVC_AP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
