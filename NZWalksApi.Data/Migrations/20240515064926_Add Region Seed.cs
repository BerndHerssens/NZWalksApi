using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NZWalksApi.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddRegionSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "ID", "BeautyGrade", "Created", "Description", "Name", "Updated" },
                values: new object[,]
                {
                    { 1, 4, new DateTime(2024, 5, 15, 8, 49, 25, 800, DateTimeKind.Local).AddTicks(6584), "They make Path of Exile here...", "Auckland", new DateTime(2024, 5, 15, 8, 49, 25, 800, DateTimeKind.Local).AddTicks(6665) },
                    { 2, 2, new DateTime(2024, 5, 15, 8, 49, 25, 800, DateTimeKind.Local).AddTicks(6672), "Best day hike for active families 13km (8 miles), 4-5 hours, easy to moderate.", "Kosciuszko", new DateTime(2024, 5, 15, 8, 49, 25, 800, DateTimeKind.Local).AddTicks(6673) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "ID",
                keyValue: 2);
        }
    }
}
