using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AEMTest.Migrations
{
    /// <inheritdoc />
    public partial class addedlatitudelongitude : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Latitude",
                table: "Platforms",
                type: "double",
                nullable: true,
                defaultValue: null);

            migrationBuilder.AddColumn<double>(
                name: "Longitude",
                table: "Platforms",
                type: "double",
                nullable: true,
                defaultValue: null);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Latitude",
                table: "Platforms");

            migrationBuilder.DropColumn(
                name: "Longitude",
                table: "Platforms");
        }
    }
}
