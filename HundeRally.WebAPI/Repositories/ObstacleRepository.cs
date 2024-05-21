using HundeRally.WebAPI.Data;
using HundeRally.WebAPI.Entities;
using HundeRally.WebAPI.Interface;

namespace HundeRally.WebAPI.Repositories
{
    public class ObstacleRepository : IObstacleRepository
    {
        private readonly DataContext _context;
        public ObstacleRepository(DataContext context)
        {
            _context = context;
        }
        public IEnumerable<Obstacle> GetAllObstacles()
        {
            throw new System.NotImplementedException();
        }
        
        public void AddObstacle(Obstacle obstacle)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteObstacle(int id)
        {
            throw new System.NotImplementedException();
        }

        public Obstacle GetObstacleById(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Save()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateObstacle(Obstacle obstacle)
        {
            throw new NotImplementedException();
        }
    }
}
