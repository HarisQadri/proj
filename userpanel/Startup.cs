using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(userpanel.Startup))]
namespace userpanel
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
