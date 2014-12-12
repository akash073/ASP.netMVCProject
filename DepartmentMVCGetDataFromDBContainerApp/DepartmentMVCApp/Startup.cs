using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DepartmentMVCApp.Startup))]
namespace DepartmentMVCApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
