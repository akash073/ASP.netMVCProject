using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StudentSolution.Startup))]
namespace StudentSolution
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
