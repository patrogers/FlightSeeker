using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FlightSeeker.Startup))]
namespace FlightSeeker
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
