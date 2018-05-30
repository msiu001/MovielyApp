using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Moviely2.Startup))]
namespace Moviely2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
