using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Car4Hire.Startup))]
namespace Car4Hire
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
