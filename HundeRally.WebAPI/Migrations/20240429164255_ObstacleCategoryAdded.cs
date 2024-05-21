using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HundeRally.WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class ObstacleCategoryAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Obstacles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "ObstacleCategory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ObstacleCategory", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Obstacles_CategoryId",
                table: "Obstacles",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Obstacles_ObstacleCategory_CategoryId",
                table: "Obstacles",
                column: "CategoryId",
                principalTable: "ObstacleCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Obstacles_ObstacleCategory_CategoryId",
                table: "Obstacles");

            migrationBuilder.DropTable(
                name: "ObstacleCategory");

            migrationBuilder.DropIndex(
                name: "IX_Obstacles_CategoryId",
                table: "Obstacles");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Obstacles");
        }
    }
}
