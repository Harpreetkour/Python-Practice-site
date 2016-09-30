using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Project9_28.Startup))]
namespace Project9_28
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
