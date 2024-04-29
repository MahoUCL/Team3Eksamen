namespace HundeRally.WebAPI.Entities
{
    public class Obstacle
    {
        public int Id { get; set; }
        public int? Number { get; set; }
        public required string Name { get; set; }
        public string? Description { get; set; } = string.Empty;
    }
}
