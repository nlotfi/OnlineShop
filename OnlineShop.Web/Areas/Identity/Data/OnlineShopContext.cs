using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OnlineShop.Web.Areas.Identity.Data;

namespace OnlineShop.Web.Data
{
    public class OnlineShopContext : IdentityDbContext<OnlineShopUser>
    {
        public OnlineShopContext(DbContextOptions<OnlineShopContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }

        public DbSet<Product> Products { get; set; }
    }
    public class Product
    {
        public int Id { get; set; }

        public string Title { get; set; }
    }
}
