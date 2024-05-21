using HundeRally.WebUI.Domain.Entity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebUI.Domain.Entity;

namespace HundeRally.WebUI.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<Obstacle> Obstacles { get; set; }
        public DbSet<ObstacleCourses> ObstacleCourses { get; set; }

    }
}
