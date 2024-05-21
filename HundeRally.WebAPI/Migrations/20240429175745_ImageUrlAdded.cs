using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HundeRally.WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class ImageUrlAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Obstacles_ObstacleCategory_CategoryId",
                table: "Obstacles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ObstacleCategory",
                table: "ObstacleCategory");

            migrationBuilder.RenameTable(
                name: "ObstacleCategory",
                newName: "ObstacleCategories");

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Obstacles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ObstacleCategories",
                table: "ObstacleCategories",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Obstacles_ObstacleCategories_CategoryId",
                table: "Obstacles",
                column: "CategoryId",
                principalTable: "ObstacleCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Obstacles_ObstacleCategories_CategoryId",
                table: "Obstacles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ObstacleCategories",
                table: "ObstacleCategories");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Obstacles");

            migrationBuilder.RenameTable(
                name: "ObstacleCategories",
                newName: "ObstacleCategory");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ObstacleCategory",
                table: "ObstacleCategory",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Obstacles_ObstacleCategory_CategoryId",
                table: "Obstacles",
                column: "CategoryId",
                principalTable: "ObstacleCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
