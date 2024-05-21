using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HundeRally.WebUI.Migrations
{
    /// <inheritdoc />
    public partial class obstacles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "obstacle_difficulty",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    difficulty_name = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_obstacle_difficulty", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "obstacle",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    obstacle_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    obstacle_number = table.Column<int>(type: "int", maxLength: 4, nullable: true),
                    description = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    obstacle_img_url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    difficulty_id = table.Column<int>(type: "int", nullable: false),
                    DifficultyNameId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_obstacle", x => x.id);
                    table.ForeignKey(
                        name: "FK_obstacle_obstacle_difficulty_DifficultyNameId",
                        column: x => x.DifficultyNameId,
                        principalTable: "obstacle_difficulty",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_obstacle_DifficultyNameId",
                table: "obstacle",
                column: "DifficultyNameId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "obstacle");

            migrationBuilder.DropTable(
                name: "obstacle_difficulty");
        }
    }
}
