using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ShopCustomerSystem.Startup))]
namespace ShopCustomerSystem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
