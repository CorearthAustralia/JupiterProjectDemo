using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JupiterProjectDemo.Startup))]
namespace JupiterProjectDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
