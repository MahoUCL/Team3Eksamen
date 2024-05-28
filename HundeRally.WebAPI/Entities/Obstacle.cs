using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HundeRally.WebAPI.Entities
{
    [Table("obstacle")]
    public class Obstacle
    {

        [Column("id")]
        [Key]
        public int Id { get; set; }

        [Column("obstacle_name")]
        [MaxLength(50)]
        public string? ObstacleName { get; set; }

        [Column("obstacle_number")]
        [MaxLength(4)]
        public int? ObstacleNumber { get; set; }

        [Column("description")]
        [MaxLength(300)]
        public string? ObstacleDescription { get; set; }

        [Column("obstacle_img_url")]
        public string? ObstacleImgUrl { get; set; }

        [Column("difficulty")]
        [ForeignKey(nameof(ObstacleDifficulty))]
        public int DifficultyName { get; set; }

        public ObstacleDifficulty? ObstacleDifficulty { get; set; }
    }

    //public class Obstacle
    //{
    //    public int Id { get; set; }
    //    public int? Number { get; set; }
    //    public required string Name { get; set; }
    //    public string? Description { get; set; } = string.Empty;
    //    public int ObstacleCategoryId { get; set; }
    //    public ObstacleCategory category { get; set; }
    //    public string? ImageUrl { get; set; } = string.Empty;
    //}




}
