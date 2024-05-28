using System.Data.Entity;
using Microsoft.Owin;
using Owin;
using KhumaloCraftApplication.Models;

[assembly: OwinStartup(typeof(KhumaloCraftApplication.Startup))]

namespace KhumaloCraftApplication
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }

        public static void ConfigureAuth(IAppBuilder app)
        {
            // Configure the database context
            Database.SetInitializer<KhumaloCraftDbContext>(null);

            // Example: Configure cookie authentication if needed
            app.UseCookieAuthentication(new Microsoft.Owin.Security.Cookies.CookieAuthenticationOptions
            {
                AuthenticationType = "ApplicationCookie",
                LoginPath = new PathString("/Account/Login"),
            });

        }
    }
}
