using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TheButlerV3.Startup))]
namespace TheButlerV3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
