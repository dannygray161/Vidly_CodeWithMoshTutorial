using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Vidly_CodeWithMoshTutorial.Startup))]
namespace Vidly_CodeWithMoshTutorial
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
