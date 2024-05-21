using HundeRally.WebUI.Migrations;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HundeRally.WebUI.Domain.Entity
{
    [Table("obstacleCourses")]

    public class ObstacleCourses
    {
        [Key]
        public int Id { get; set; }
        public string? CourseName { get; set; } = null;
        public string? CourseDescription { get; set; } = null;
        public ObstacleCellPlacement ObstacleCellPlacement { get; set; }
        

    }
}
