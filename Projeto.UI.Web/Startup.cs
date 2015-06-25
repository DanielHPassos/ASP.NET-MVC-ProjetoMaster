using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Projeto.UI.Web.Startup))]
namespace Projeto.UI.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
