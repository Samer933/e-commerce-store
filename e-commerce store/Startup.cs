using e_commerce_store.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Microsoft.Owin.Security;
using Microsoft.AspNet.Identity;
using Owin;

[assembly: OwinStartupAttribute(typeof(e_commerce_store.Startup))]
namespace e_commerce_store
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);



        }
    }
}