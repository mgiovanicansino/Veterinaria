using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Veterinaria.Startup))]
namespace Veterinaria
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
