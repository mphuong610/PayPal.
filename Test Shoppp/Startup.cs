using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Test_Shoppp.Startup))]
namespace Test_Shoppp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
