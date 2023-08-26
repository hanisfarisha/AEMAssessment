using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AEMTest.Migrations
{
    /// <inheritdoc />
    public partial class addedwell : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PlatformId1",
                table: "Platforms",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Wells",
                columns: table => new
                {
                    WellId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlatformId = table.Column<int>(type: "int", nullable: false),
                    WellString = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDatetime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedDatetime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wells", x => x.WellId);
                    table.ForeignKey(
                        name: "FK_Wells_Platforms_PlatformId",
                        column: x => x.PlatformId,
                        principalTable: "Platforms",
                        principalColumn: "PlatformId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Platforms_PlatformId1",
                table: "Platforms",
                column: "PlatformId1");

            migrationBuilder.CreateIndex(
                name: "IX_Wells_PlatformId",
                table: "Wells",
                column: "PlatformId");

            migrationBuilder.AddForeignKey(
                name: "FK_Platforms_Platforms_PlatformId1",
                table: "Platforms",
                column: "PlatformId1",
                principalTable: "Platforms",
                principalColumn: "PlatformId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Platforms_Platforms_PlatformId1",
                table: "Platforms");

            migrationBuilder.DropTable(
                name: "Wells");

            migrationBuilder.DropIndex(
                name: "IX_Platforms_PlatformId1",
                table: "Platforms");

            migrationBuilder.DropColumn(
                name: "PlatformId1",
                table: "Platforms");
        }
    }
}
