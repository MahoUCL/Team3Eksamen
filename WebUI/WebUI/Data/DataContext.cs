using Microsoft.EntityFrameworkCore;
using WebUI.Domain.Entity;

namespace WebUI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        
        public DbSet<Obstacle> Obstacles { get; set; } 

    }
}
