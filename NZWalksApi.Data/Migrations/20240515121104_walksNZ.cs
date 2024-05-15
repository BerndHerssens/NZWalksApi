using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NZWalksApi.Data.Migrations
{
    /// <inheritdoc />
    public partial class walksNZ : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2024, 5, 15, 14, 11, 4, 478, DateTimeKind.Local).AddTicks(2470), new DateTime(2024, 5, 15, 14, 11, 4, 478, DateTimeKind.Local).AddTicks(2514) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2024, 5, 15, 14, 11, 4, 478, DateTimeKind.Local).AddTicks(2518), new DateTime(2024, 5, 15, 14, 11, 4, 478, DateTimeKind.Local).AddTicks(2519) });

            migrationBuilder.UpdateData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2024, 5, 15, 14, 11, 4, 478, DateTimeKind.Local).AddTicks(2585), new DateTime(2024, 5, 15, 14, 11, 4, 478, DateTimeKind.Local).AddTicks(2586) });

            migrationBuilder.UpdateData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2024, 5, 15, 14, 11, 4, 478, DateTimeKind.Local).AddTicks(2589), new DateTime(2024, 5, 15, 14, 11, 4, 478, DateTimeKind.Local).AddTicks(2590) });

            migrationBuilder.UpdateData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2024, 5, 15, 14, 11, 4, 478, DateTimeKind.Local).AddTicks(2592), new DateTime(2024, 5, 15, 14, 11, 4, 478, DateTimeKind.Local).AddTicks(2593) });

            migrationBuilder.UpdateData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2024, 5, 15, 14, 11, 4, 478, DateTimeKind.Local).AddTicks(2595), new DateTime(2024, 5, 15, 14, 11, 4, 478, DateTimeKind.Local).AddTicks(2596) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2024, 5, 15, 11, 47, 25, 897, DateTimeKind.Local).AddTicks(6978), new DateTime(2024, 5, 15, 11, 47, 25, 897, DateTimeKind.Local).AddTicks(7025) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2024, 5, 15, 11, 47, 25, 897, DateTimeKind.Local).AddTicks(7028), new DateTime(2024, 5, 15, 11, 47, 25, 897, DateTimeKind.Local).AddTicks(7029) });

            migrationBuilder.UpdateData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2024, 5, 15, 11, 47, 25, 897, DateTimeKind.Local).AddTicks(7096), new DateTime(2024, 5, 15, 11, 47, 25, 897, DateTimeKind.Local).AddTicks(7097) });

            migrationBuilder.UpdateData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2024, 5, 15, 11, 47, 25, 897, DateTimeKind.Local).AddTicks(7102), new DateTime(2024, 5, 15, 11, 47, 25, 897, DateTimeKind.Local).AddTicks(7103) });

            migrationBuilder.UpdateData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2024, 5, 15, 11, 47, 25, 897, DateTimeKind.Local).AddTicks(7104), new DateTime(2024, 5, 15, 11, 47, 25, 897, DateTimeKind.Local).AddTicks(7105) });

            migrationBuilder.UpdateData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2024, 5, 15, 11, 47, 25, 897, DateTimeKind.Local).AddTicks(7107), new DateTime(2024, 5, 15, 11, 47, 25, 897, DateTimeKind.Local).AddTicks(7108) });
        }
    }
}
