using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Niagara_Hospice.Startup))]
namespace Niagara_Hospice
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
