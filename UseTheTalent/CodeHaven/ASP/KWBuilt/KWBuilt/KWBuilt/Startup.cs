using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KWBuilt.Startup))]
namespace KWBuilt
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
