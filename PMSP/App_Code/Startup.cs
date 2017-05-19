using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PMSP.Startup))]
namespace PMSP
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
