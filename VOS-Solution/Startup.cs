using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VOS_Solution.Startup))]
namespace VOS_Solution
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
