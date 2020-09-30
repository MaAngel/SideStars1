using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SideStars1.Startup))]
namespace SideStars1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
