using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TasKTrackerApp.Areas.Identity.Data;
using TasKTrackerApp.Data;

[assembly: HostingStartup(typeof(TasKTrackerApp.Areas.Identity.IdentityHostingStartup))]
namespace TasKTrackerApp.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<ApplicationUserContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("ApplicationUserContextConnection")));

                services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<ApplicationUserContext>();
            });
        }
    }
}