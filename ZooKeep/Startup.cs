using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ZooKeep.Startup))]
namespace ZooKeep
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
