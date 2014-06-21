using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Poolio.Startup))]
namespace Poolio
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
