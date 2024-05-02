using HundeRally.WebAPI.Entities;

namespace HundeRally.WebAPI.Interface
{
    public interface IObstacleRepository
    {
        IEnumerable<Obstacle> GetAllObstacles();

        Obstacle GetObstacleById(int id);

        void AddObstacle(Obstacle obstacle);

        void UpdateObstacle(Obstacle obstacle);

        void DeleteObstacle(int id);

        void Save();
    }
}
