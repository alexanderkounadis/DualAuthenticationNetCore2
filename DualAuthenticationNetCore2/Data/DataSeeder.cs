using DualAuthenticationNetCore2.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DualAuthenticationNetCore2.Data
{
    public class DataSeeder
    {
        private readonly DualAuthenticationNetCore2DbContext _ctx;
        private readonly UserManager<ApplicationUser> _userManager;

        public DataSeeder(DualAuthenticationNetCore2DbContext ctx , UserManager<ApplicationUser> userManager)
        {
            _ctx = ctx;
            _userManager = userManager;
        }

        public async Task SeedAsync()
        {
            _ctx.Database.EnsureCreated();

            if(!_ctx.Users.Any())
            {
                ApplicationUser user = new ApplicationUser()
                {
                    Email = "bob@aol.com",
                    UserName = "bob@aol.com"
                };

                var result = await _userManager.CreateAsync(user, "p@$$w0rd");
                if  (result.Succeeded)
                {
                    user.EmailConfirmed = true;
                    await _userManager.UpdateAsync(user);
                }
            }
        }
    }
}
