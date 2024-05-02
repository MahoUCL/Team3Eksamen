namespace HundeRally.WebAPI.Entities
{
    public class Obstacle
    {
        public int Id { get; set; }
        public int? Number { get; set; }
        public required string Name { get; set; }
        public string? Description { get; set; } = string.Empty;
        public int ObstacleCategoryId { get; set; }
        public ObstacleCategory category { get; set; }
        public string? ImageUrl { get; set; } = string.Empty;
    }




}
