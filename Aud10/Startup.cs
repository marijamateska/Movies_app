using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Aud10.Startup))]
namespace Aud10
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
