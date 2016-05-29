using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EFSandbox.Web.Startup))]
namespace EFSandbox.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
