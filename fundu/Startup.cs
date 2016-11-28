using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(fundu.Startup))]
namespace fundu
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
