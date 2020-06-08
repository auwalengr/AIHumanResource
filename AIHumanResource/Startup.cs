using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AIHumanResource.Startup))]
namespace AIHumanResource
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
