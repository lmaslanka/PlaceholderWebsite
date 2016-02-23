using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BurgessvilleBaptist.Web.Startup))]
namespace BurgessvilleBaptist.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
