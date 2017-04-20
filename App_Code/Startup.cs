using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NVision.Startup))]
namespace NVision
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
