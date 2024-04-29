using HundeRally.Logic.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HundeRally.Logic.Data
{
    public class RallyContext : DbContext
    {
        public RallyContext(DbContextOptions<RallyContext> options) : base(options) { }

        public DbSet<ObstacleCourse> ObstacleCourses { get; set; }
        public DbSet<Obstacle> Obstacles { get; set; }
    }

    
}
