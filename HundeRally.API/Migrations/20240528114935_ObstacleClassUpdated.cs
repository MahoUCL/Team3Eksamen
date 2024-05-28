using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HundeRally.API.Migrations
{
    /// <inheritdoc />
    public partial class ObstacleClassUpdated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Obstacles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Number",
                table: "Obstacles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "Obstacles",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Obstacles");

            migrationBuilder.DropColumn(
                name: "Number",
                table: "Obstacles");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Obstacles");
        }
    }
}
