using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HundeRally.Logic.Data;
using HundeRally.Logic.Entity;
using HundeRally.Logic.Repositories;
using static HundeRally.Logic.interfaces;



namespace HundeRally.Logic.Repositories
{
    public class ObstacleRepository : IObstacleRepository
    {
        private readonly RallyContext _context;

        public ObstacleRepository(RallyContext context)
        {
            _context = context;
        }

        public IEnumerable<Obstacle> GetAllObstacles()
        {
            throw new NotImplementedException();
        }

        public void AddObstacle(Obstacle obstacle)
        {
            throw new NotImplementedException();
        }

        public void DeleteObstacle(int id)
        {
            throw new NotImplementedException();
        }

        public Obstacle GetObstacleById(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateObstacle(Obstacle obstacle)
        {
            throw new NotImplementedException();
        }

    }
}
