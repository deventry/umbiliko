using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Umbiliko.Demo.Startup))]
namespace Umbiliko.Demo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
