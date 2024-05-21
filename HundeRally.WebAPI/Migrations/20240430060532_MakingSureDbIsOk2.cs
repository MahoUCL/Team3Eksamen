using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HundeRally.WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class MakingSureDbIsOk2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Obstacles_ObstacleCategories_obstacleCategoryId",
                table: "Obstacles");

            migrationBuilder.RenameColumn(
                name: "obstacleCategoryId",
                table: "Obstacles",
                newName: "ObstacleCategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Obstacles_obstacleCategoryId",
                table: "Obstacles",
                newName: "IX_Obstacles_ObstacleCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Obstacles_ObstacleCategories_ObstacleCategoryId",
                table: "Obstacles",
                column: "ObstacleCategoryId",
                principalTable: "ObstacleCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Obstacles_ObstacleCategories_ObstacleCategoryId",
                table: "Obstacles");

            migrationBuilder.RenameColumn(
                name: "ObstacleCategoryId",
                table: "Obstacles",
                newName: "obstacleCategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Obstacles_ObstacleCategoryId",
                table: "Obstacles",
                newName: "IX_Obstacles_obstacleCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Obstacles_ObstacleCategories_obstacleCategoryId",
                table: "Obstacles",
                column: "obstacleCategoryId",
                principalTable: "ObstacleCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
