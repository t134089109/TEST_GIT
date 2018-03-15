using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TEST_GIT.Startup))]
namespace TEST_GIT
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
