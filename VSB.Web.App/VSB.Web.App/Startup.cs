using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VSB.Web.App.Startup))]
namespace VSB.Web.App
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
