using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DiagnosticCenterBillManagement.Startup))]
namespace DiagnosticCenterBillManagement
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
