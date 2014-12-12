using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UniversityFinalProject.Startup))]
namespace UniversityFinalProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
