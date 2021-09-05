using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OnlineShop.Web.Areas.Identity.Data;
using OnlineShop.Web.Data;

[assembly: HostingStartup(typeof(OnlineShop.Web.Areas.Identity.IdentityHostingStartup))]
namespace OnlineShop.Web.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<OnlineShopContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("OnlineShopContextConnection")));

                services.AddDefaultIdentity<OnlineShopUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<OnlineShopContext>();
            });
        }
    }
}