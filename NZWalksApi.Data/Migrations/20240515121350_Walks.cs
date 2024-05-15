using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NZWalksApi.Data.Migrations
{
    /// <inheritdoc />
    public partial class Walks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2024, 5, 15, 14, 13, 49, 987, DateTimeKind.Local).AddTicks(5951), new DateTime(2024, 5, 15, 14, 13, 49, 987, DateTimeKind.Local).AddTicks(6002) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2024, 5, 15, 14, 13, 49, 987, DateTimeKind.Local).AddTicks(6005), new DateTime(2024, 5, 15, 14, 13, 49, 987, DateTimeKind.Local).AddTicks(6006) });

            migrationBuilder.UpdateData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2024, 5, 15, 14, 13, 49, 987, DateTimeKind.Local).AddTicks(6078), new DateTime(2024, 5, 15, 14, 13, 49, 987, DateTimeKind.Local).AddTicks(6079) });

            migrationBuilder.UpdateData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2024, 5, 15, 14, 13, 49, 987, DateTimeKind.Local).AddTicks(6083), new DateTime(2024, 5, 15, 14, 13, 49, 987, DateTimeKind.Local).AddTicks(6083) });

            migrationBuilder.UpdateData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2024, 5, 15, 14, 13, 49, 987, DateTimeKind.Local).AddTicks(6085), new DateTime(2024, 5, 15, 14, 13, 49, 987, DateTimeKind.Local).AddTicks(6086) });

            migrationBuilder.UpdateData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2024, 5, 15, 14, 13, 49, 987, DateTimeKind.Local).AddTicks(6088), new DateTime(2024, 5, 15, 14, 13, 49, 987, DateTimeKind.Local).AddTicks(6089) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
