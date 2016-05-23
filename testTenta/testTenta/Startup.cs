using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(testTenta.Startup))]
namespace testTenta
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
