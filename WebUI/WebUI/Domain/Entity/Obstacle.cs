using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebUI.Domain.Entity
{
    [Table("obstacle")]
    public class Obstacle
    {

        [Column("id")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        
        [Column("obstacle_name")]
        [MaxLength(50)]
        public string? ObstacleName { get; set; }
        
        [Column("obstacle_number")]
        [MaxLength(4)]
        public int? ObstacleNumber{ get; set; }
        
        [Column("description")]
        [MaxLength(300)]
        public string? ObstacleDescription { get; set; }
        
        [Column("obstacle_img_url")]
        public string? ObstacleImgUrl { get; set; }

        [Column("difficulty_id")]
        [ForeignKey(nameof(ObstacleDifficulty))]
        public int Diffucltyid { get; set; }

        public ObstacleDifficulty? DifficultyName { get; set;}
    }
}
