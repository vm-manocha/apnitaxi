using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ApniTaxi.Startup))]
namespace ApniTaxi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
