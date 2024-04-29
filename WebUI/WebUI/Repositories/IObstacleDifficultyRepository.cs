using WebUI.Domain.Entity;

namespace WebUI.Repositories
{
    public interface IObstacleDifficultyRepository
    {
        public Task<List<ObstacleDifficulty>> Get();
    }
}
