using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAppProvaB2Rayane.Startup))]
namespace WebAppProvaB2Rayane
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
