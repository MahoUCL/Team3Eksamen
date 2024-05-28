using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebUI.Domain.Entity;

namespace HundeRally.WebUI.Data
{

    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        //Defines the obstacle table for Entity Framework
        public DbSet<Obstacle> Obstacles { get; set; }

    }
}
