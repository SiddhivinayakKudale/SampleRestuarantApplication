using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SampleRestuarantApplication.Startup))]
namespace SampleRestuarantApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
