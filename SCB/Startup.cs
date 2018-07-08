using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SCB.Startup))]
namespace SCB
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
