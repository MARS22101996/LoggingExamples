using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Serilog.Startup))]
namespace Serilog
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
