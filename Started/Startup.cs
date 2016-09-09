using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Started.Startup))]
namespace Started
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
