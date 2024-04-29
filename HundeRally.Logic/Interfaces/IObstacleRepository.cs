using HundeRally.Logic.Entity;

namespace HundeRally.Logic;
public partial interface interfaces
    {
    public interface IObstacleRepository
    {
        IEnumerable<Obstacle> GetAllObstacles();
        Obstacle GetObstacleById(int id);
        void AddObstacle(Obstacle obstacle);
        void UpdateObstacle(Obstacle obstacle);
        void DeleteObstacle(int id);
        // ... other methods for CRUD operations on obstacles
    }
}
