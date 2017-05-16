using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TechMVCDatabase.Startup))]
namespace TechMVCDatabase
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
