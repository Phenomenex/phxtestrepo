using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(phxtestGitProject.Startup))]
namespace phxtestGitProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
