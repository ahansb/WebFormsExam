using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PlaylistSystem.Startup))]
namespace PlaylistSystem
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
