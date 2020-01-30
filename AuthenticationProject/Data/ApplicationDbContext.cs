using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AuthenticationProject.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        
        //register models database
        public DbSet<GuestUser> GuestUsers { get; set; }
        public DbSet<AdminUser> AdminUsers { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            // seeding the database
            var roles = new List<IdentityRole>()
            {
                new IdentityRole{Name="Guest", NormalizedName="GUEST" },
                 new IdentityRole{Name="Admin", NormalizedName="ADMIN" }

            };


            // populate the database i.e identity role table :: database seeding
            builder.Entity<IdentityRole>().HasData(roles);
            base.OnModelCreating(builder);
        }
    }
}
