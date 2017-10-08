using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RobotPlatform.Startup))]
namespace RobotPlatform
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
