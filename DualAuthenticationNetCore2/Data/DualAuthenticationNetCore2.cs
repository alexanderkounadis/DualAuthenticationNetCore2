using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using DualAuthenticationNetCore2.Models;

namespace DualAuthenticationNetCore2.Data
{
    public class DualAuthenticationNetCore2DbContext : IdentityDbContext<ApplicationUser>
    {
        public DualAuthenticationNetCore2DbContext(DbContextOptions<DualAuthenticationNetCore2DbContext> options)
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
    }
}
