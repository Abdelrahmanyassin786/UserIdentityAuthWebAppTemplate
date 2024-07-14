using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using UserIdentityAuthWebAppTemplate.Models;

namespace UserIdentityAuthWebAppTemplate.Data
{
    public class AppDBContext : IdentityDbContext<ApplicationUser>
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
            //empty for now.
        }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

        //seeding database
        //also necessary for later DB operations and changing stuff
        //part of basic config
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
