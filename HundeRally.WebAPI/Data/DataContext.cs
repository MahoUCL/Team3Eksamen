using HundeRally.WebAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace HundeRally.WebAPI.Data
{
    public class DataContext : DbContext
    {
        
        public DbSet<Obstacle> Obstacles { get; set; }
        public DbSet<ObstacleDifficulty> Difficulty { get; set; }
    }
}
