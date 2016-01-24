using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TTT.UI.Startup))]
namespace TTT.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
