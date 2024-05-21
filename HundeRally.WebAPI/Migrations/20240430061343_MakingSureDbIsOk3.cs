using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HundeRally.WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class MakingSureDbIsOk3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Obstacles_ObstacleCategories_ObstacleCategoryId",
                table: "Obstacles");

            migrationBuilder.RenameColumn(
                name: "ObstacleCategoryId",
                table: "Obstacles",
                newName: "categoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Obstacles_ObstacleCategoryId",
                table: "Obstacles",
                newName: "IX_Obstacles_categoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Obstacles_ObstacleCategories_categoryId",
                table: "Obstacles",
                column: "categoryId",
                principalTable: "ObstacleCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Obstacles_ObstacleCategories_categoryId",
                table: "Obstacles");

            migrationBuilder.RenameColumn(
                name: "categoryId",
                table: "Obstacles",
                newName: "ObstacleCategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Obstacles_categoryId",
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
    }
}
