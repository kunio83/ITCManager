using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ITCManager.Startup))]
namespace ITCManager
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
