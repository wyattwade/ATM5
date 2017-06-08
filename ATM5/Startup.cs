using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ATM5.Startup))]
namespace ATM5
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
