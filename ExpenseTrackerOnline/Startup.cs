using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ExpenseTrackerOnline.Startup))]
namespace ExpenseTrackerOnline
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
