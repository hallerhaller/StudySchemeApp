using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StudyScheme.Startup))]
namespace StudyScheme
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
