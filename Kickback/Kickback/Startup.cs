using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Kickback.Startup))]
namespace Kickback
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
