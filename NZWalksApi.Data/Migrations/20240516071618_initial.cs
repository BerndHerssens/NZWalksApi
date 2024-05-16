using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NZWalksApi.Data.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Regions",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BeautyGrade = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Regions", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Walks",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LengthInKm = table.Column<double>(type: "float", nullable: false),
                    RegionID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Walks", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Walks_Regions_RegionID",
                        column: x => x.RegionID,
                        principalTable: "Regions",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "ID", "BeautyGrade", "Created", "Description", "Name", "Updated" },
                values: new object[,]
                {
                    { 1, 4, new DateTime(2024, 5, 16, 9, 16, 18, 359, DateTimeKind.Local).AddTicks(684), "They make Path of Exile here...", "Auckland", new DateTime(2024, 5, 16, 9, 16, 18, 359, DateTimeKind.Local).AddTicks(735) },
                    { 2, 2, new DateTime(2024, 5, 16, 9, 16, 18, 359, DateTimeKind.Local).AddTicks(740), "Best day hike for active families 13km (8 miles), 4-5 hours, easy to moderate.", "Kosciuszko", new DateTime(2024, 5, 16, 9, 16, 18, 359, DateTimeKind.Local).AddTicks(742) }
                });

            migrationBuilder.InsertData(
                table: "Walks",
                columns: new[] { "ID", "Created", "Description", "LengthInKm", "Name", "RegionID", "Updated" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 5, 16, 9, 16, 18, 359, DateTimeKind.Local).AddTicks(821), "This is a beautiful walk by the ocean", 20.5, "Great ocean walk", 1, new DateTime(2024, 5, 16, 9, 16, 18, 359, DateTimeKind.Local).AddTicks(823) },
                    { 2, new DateTime(2024, 5, 16, 9, 16, 18, 359, DateTimeKind.Local).AddTicks(826), "This is a beautiful walk in the forrest", 10.5, "Great forrest walk", 1, new DateTime(2024, 5, 16, 9, 16, 18, 359, DateTimeKind.Local).AddTicks(827) },
                    { 3, new DateTime(2024, 5, 16, 9, 16, 18, 359, DateTimeKind.Local).AddTicks(830), "This is a beautiful walk by a lake", 15.5, "Great lake walk", 1, new DateTime(2024, 5, 16, 9, 16, 18, 359, DateTimeKind.Local).AddTicks(831) },
                    { 4, new DateTime(2024, 5, 16, 9, 16, 18, 359, DateTimeKind.Local).AddTicks(833), "This is a beautiful walk in the mountains", 18.5, "Great mountain walk", 2, new DateTime(2024, 5, 16, 9, 16, 18, 359, DateTimeKind.Local).AddTicks(834) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Walks_RegionID",
                table: "Walks",
                column: "RegionID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Walks");

            migrationBuilder.DropTable(
                name: "Regions");
        }
    }
}
