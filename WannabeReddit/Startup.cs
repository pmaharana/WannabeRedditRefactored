using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WannabeReddit.Startup))]
namespace WannabeReddit
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
