using HundeRally.Logic.Entity;

namespace HundeRally.Logic;

public interface IObstacleRepository
{
    IEnumerable<Obstacle> GetAllObstacles();
    Obstacle GetObstacleById(int id);
    void AddObstacle(Obstacle obstacle);
    void UpdateObstacle(Obstacle obstacle);
    void DeleteObstacle(int id);

    Task SaveChangesAsync();
    // ... other methods for CRUD operations on obstacles
}

