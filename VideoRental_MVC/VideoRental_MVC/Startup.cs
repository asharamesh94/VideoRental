using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VideoRental_MVC.Startup))]
namespace VideoRental_MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
