using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BookManager3.Startup))]
namespace BookManager3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
