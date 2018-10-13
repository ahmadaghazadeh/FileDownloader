using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FileDownloader.Startup))]
namespace FileDownloader
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
