using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ReviewsMVC.Startup))]
namespace ReviewsMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
