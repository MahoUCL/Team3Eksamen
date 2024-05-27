using HundeRally.API.Areas.Identity.Data;
using HundeRally.API.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace HundeRally.API.Areas.Identity.Data;

public class APIDataContext : IdentityDbContext<APIUser>
{
    public DbSet<Obstacle> Obstacles { get; set; }
    
    public APIDataContext(DbContextOptions<APIDataContext> options)
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
