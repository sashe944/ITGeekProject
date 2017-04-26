using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ITGeekProject.Startup))]
namespace ITGeekProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
