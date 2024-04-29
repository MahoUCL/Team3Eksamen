using HundeRally.WebAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace HundeRally.WebAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

             
        }

        public DbSet<Obstacle> Obstacles { get; set; }
        public DbSet<ObstacleCategory> ObstacleCategories { get; set; }
    }
}
