using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CollegeBookRental.Startup))]
namespace CollegeBookRental
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
