using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebUI.Domain.Entity
{
    [Table("obstacle_difficulty")]
    public class ObstacleDifficulty
    {
        [Column("id")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Column("difficulty_name")]
        [MaxLength(15)]
        public string DifficultyName { get; set; }

        public ICollection<Obstacle> Obstacles { get; set; }
    }
}
