using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigitleContent_Management.Extentions
{
    public static class ApplicationSeed
    {
        public static void Seed(this ModelBuilder model)
        {
            model.Entity<IdentityUser>().HasData(
                new IdentityUser() { 
                    UserName = "Admin",
                    Email = "admin@example.com",
                    PasswordHash = "AQAAAAEAACcQAAAAEPZbSi7Gx1GdjxZ67FF9apt6oJ086CNnjR8Urudl7bnEs1sy1cwWA0WmtrEKFly/Ag==", // P@ssw0rd
                }
            );
        }
    }
}
