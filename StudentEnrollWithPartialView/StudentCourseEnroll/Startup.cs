using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StudentCourseEnroll.Startup))]
namespace StudentCourseEnroll
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
