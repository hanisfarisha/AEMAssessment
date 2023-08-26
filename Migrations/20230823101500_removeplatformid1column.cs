using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AEMTest.Migrations
{
    /// <inheritdoc />
    public partial class removeplatformid1column : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Platforms_Platforms_PlatformId1",
                table: "Platforms");

            migrationBuilder.DropIndex(
                name: "IX_Platforms_PlatformId1",
                table: "Platforms");

            migrationBuilder.DropColumn(
                name: "PlatformId1",
                table: "Platforms");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PlatformId1",
                table: "Platforms",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Platforms_PlatformId1",
                table: "Platforms",
                column: "PlatformId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Platforms_Platforms_PlatformId1",
                table: "Platforms",
                column: "PlatformId1",
                principalTable: "Platforms",
                principalColumn: "PlatformId");
        }
    }
}
