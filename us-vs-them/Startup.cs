using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(us_vs_them.Startup))]
namespace us_vs_them
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
