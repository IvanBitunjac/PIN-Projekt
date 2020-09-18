using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PIN_Projekt.Startup))]
namespace PIN_Projekt
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
