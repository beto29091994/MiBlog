using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MiBlog.Startup))]
namespace MiBlog
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
