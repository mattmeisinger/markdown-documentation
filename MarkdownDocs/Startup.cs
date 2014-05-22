using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MarkdownDocs.Startup))]
namespace MarkdownDocs
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
