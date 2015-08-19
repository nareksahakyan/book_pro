using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(book_pro1.Startup))]
namespace book_pro1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
