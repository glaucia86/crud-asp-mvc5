using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GL.ManagementApp.Presentation.UI.Management.Startup))]
namespace GL.ManagementApp.Presentation.UI.Management
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
