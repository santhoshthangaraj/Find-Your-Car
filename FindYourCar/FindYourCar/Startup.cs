using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FindYourCar.Startup))]
namespace FindYourCar
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
