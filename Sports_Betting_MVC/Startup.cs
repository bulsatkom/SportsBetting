using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Sports_Betting_MVC.Startup))]
namespace Sports_Betting_MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);            
        }
    }
}
