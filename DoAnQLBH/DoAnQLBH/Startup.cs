using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DoAnQLBH.Startup))]
namespace DoAnQLBH
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
