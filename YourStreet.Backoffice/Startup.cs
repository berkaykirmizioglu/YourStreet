using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(YourStreet.Backoffice.Startup))]
namespace YourStreet.Backoffice
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
