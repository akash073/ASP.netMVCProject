using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(officeApp.Startup))]
namespace officeApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
