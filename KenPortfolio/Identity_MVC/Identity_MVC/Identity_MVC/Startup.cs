using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Identity_MVC.Startup))]
namespace Identity_MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
