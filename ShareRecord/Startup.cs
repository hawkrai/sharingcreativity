using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ShareRecord.Startup))]
namespace ShareRecord
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
