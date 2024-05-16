using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NZWalksApi.Data.Migrations
{
    /// <inheritdoc />
    public partial class additionalSeeds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "BeautyGrade", "Created", "Description", "Name", "Updated" },
                values: new object[] { 3, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7331), "Description for region 1", "Region 1", new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7368) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Created", "Description", "Name", "Updated" },
                values: new object[] { new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7375), "Description for region 2", "Region 2", new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7376) });

            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "ID", "BeautyGrade", "Created", "Description", "Name", "Updated" },
                values: new object[,]
                {
                    { 3, 1, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7378), "Description for region 3", "Region 3", new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7379) },
                    { 4, 2, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7382), "Description for region 4", "Region 4", new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7383) },
                    { 5, 1, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7386), "Description for region 5", "Region 5", new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7387) },
                    { 6, 0, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7392), "Description for region 6", "Region 6", new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7393) },
                    { 7, 0, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7395), "Description for region 7", "Region 7", new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7396) },
                    { 8, 3, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7401), "Description for region 8", "Region 8", new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7402) },
                    { 9, 1, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7404), "Description for region 9", "Region 9", new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7405) },
                    { 10, 3, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7409), "Description for region 10", "Region 10", new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7410) }
                });

            migrationBuilder.UpdateData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Created", "Description", "LengthInKm", "Name", "RegionID", "Updated" },
                values: new object[] { new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7528), "Description for walk 1", 17.0, "Walk 1", 10, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7530) });

            migrationBuilder.UpdateData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Created", "Description", "LengthInKm", "Name", "RegionID", "Updated" },
                values: new object[] { new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7533), "Description for walk 2", 10.0, "Walk 2", 3, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7534) });

            migrationBuilder.UpdateData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "Created", "Description", "LengthInKm", "Name", "RegionID", "Updated" },
                values: new object[] { new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7537), "Description for walk 3", 6.0, "Walk 3", 5, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7538) });

            migrationBuilder.UpdateData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "Created", "Description", "LengthInKm", "Name", "RegionID", "Updated" },
                values: new object[] { new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7540), "Description for walk 4", 9.0, "Walk 4", 10, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7541) });

            migrationBuilder.InsertData(
                table: "Walks",
                columns: new[] { "ID", "Created", "Description", "LengthInKm", "Name", "RegionID", "Updated" },
                values: new object[,]
                {
                    { 5, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7543), "Description for walk 5", 14.0, "Walk 5", 2, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7544) },
                    { 8, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7554), "Description for walk 8", 7.0, "Walk 8", 2, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7555) },
                    { 10, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7604), "Description for walk 10", 4.0, "Walk 10", 1, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7606) },
                    { 32, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7681), "Description for walk 32", 13.0, "Walk 32", 2, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7682) },
                    { 35, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7692), "Description for walk 35", 7.0, "Walk 35", 1, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7693) },
                    { 39, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7705), "Description for walk 39", 9.0, "Walk 39", 2, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7706) },
                    { 40, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7709), "Description for walk 40", 10.0, "Walk 40", 1, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7710) },
                    { 43, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7719), "Description for walk 43", 18.0, "Walk 43", 1, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7720) },
                    { 46, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7729), "Description for walk 46", 2.0, "Walk 46", 1, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7730) },
                    { 47, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7732), "Description for walk 47", 19.0, "Walk 47", 1, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7733) },
                    { 6, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7547), "Description for walk 6", 3.0, "Walk 6", 7, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7548) },
                    { 7, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7550), "Description for walk 7", 12.0, "Walk 7", 3, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7551) },
                    { 9, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7557), "Description for walk 9", 6.0, "Walk 9", 8, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7558) },
                    { 11, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7609), "Description for walk 11", 9.0, "Walk 11", 4, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7610) },
                    { 12, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7613), "Description for walk 12", 14.0, "Walk 12", 8, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7614) },
                    { 13, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7616), "Description for walk 13", 5.0, "Walk 13", 3, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7617) },
                    { 14, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7619), "Description for walk 14", 18.0, "Walk 14", 5, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7621) },
                    { 15, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7623), "Description for walk 15", 12.0, "Walk 15", 3, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7624) },
                    { 16, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7626), "Description for walk 16", 14.0, "Walk 16", 8, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7627) },
                    { 17, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7629), "Description for walk 17", 18.0, "Walk 17", 4, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7630) },
                    { 18, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7635), "Description for walk 18", 10.0, "Walk 18", 5, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7636) },
                    { 19, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7638), "Description for walk 19", 2.0, "Walk 19", 10, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7639) },
                    { 20, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7642), "Description for walk 20", 19.0, "Walk 20", 9, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7643) },
                    { 21, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7645), "Description for walk 21", 3.0, "Walk 21", 8, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7647) },
                    { 22, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7649), "Description for walk 22", 6.0, "Walk 22", 4, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7650) },
                    { 23, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7652), "Description for walk 23", 18.0, "Walk 23", 10, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7653) },
                    { 24, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7655), "Description for walk 24", 19.0, "Walk 24", 5, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7656) },
                    { 25, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7658), "Description for walk 25", 11.0, "Walk 25", 9, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7659) },
                    { 26, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7661), "Description for walk 26", 8.0, "Walk 26", 7, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7662) },
                    { 27, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7665), "Description for walk 27", 11.0, "Walk 27", 7, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7666) },
                    { 28, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7668), "Description for walk 28", 7.0, "Walk 28", 5, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7669) },
                    { 29, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7671), "Description for walk 29", 18.0, "Walk 29", 4, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7672) },
                    { 30, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7675), "Description for walk 30", 12.0, "Walk 30", 4, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7676) },
                    { 31, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7678), "Description for walk 31", 9.0, "Walk 31", 8, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7679) },
                    { 33, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7684), "Description for walk 33", 19.0, "Walk 33", 8, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7685) },
                    { 34, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7689), "Description for walk 34", 19.0, "Walk 34", 6, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7690) },
                    { 36, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7696), "Description for walk 36", 10.0, "Walk 36", 9, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7697) },
                    { 37, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7699), "Description for walk 37", 16.0, "Walk 37", 3, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7700) },
                    { 38, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7702), "Description for walk 38", 3.0, "Walk 38", 3, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7703) },
                    { 41, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7712), "Description for walk 41", 13.0, "Walk 41", 3, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7713) },
                    { 42, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7715), "Description for walk 42", 8.0, "Walk 42", 3, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7716) },
                    { 44, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7722), "Description for walk 44", 11.0, "Walk 44", 8, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7723) },
                    { 45, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7725), "Description for walk 45", 9.0, "Walk 45", 3, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7727) },
                    { 48, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7735), "Description for walk 48", 18.0, "Walk 48", 9, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7737) },
                    { 49, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7739), "Description for walk 49", 6.0, "Walk 49", 3, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7740) },
                    { 50, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7774), "Description for walk 50", 18.0, "Walk 50", 3, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7775) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "BeautyGrade", "Created", "Description", "Name", "Updated" },
                values: new object[] { 4, new DateTime(2024, 5, 16, 10, 24, 40, 580, DateTimeKind.Local).AddTicks(2836), "They make Path of Exile here...", "Auckland", new DateTime(2024, 5, 16, 10, 24, 40, 580, DateTimeKind.Local).AddTicks(2908) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Created", "Description", "Name", "Updated" },
                values: new object[] { new DateTime(2024, 5, 16, 10, 24, 40, 580, DateTimeKind.Local).AddTicks(2925), "Best day hike for active families 13km (8 miles), 4-5 hours, easy to moderate.", "Kosciuszko", new DateTime(2024, 5, 16, 10, 24, 40, 580, DateTimeKind.Local).AddTicks(2928) });

            migrationBuilder.UpdateData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Created", "Description", "LengthInKm", "Name", "RegionID", "Updated" },
                values: new object[] { new DateTime(2024, 5, 16, 10, 24, 40, 580, DateTimeKind.Local).AddTicks(3131), "This is a beautiful walk by the ocean", 20.5, "Great ocean walk", 1, new DateTime(2024, 5, 16, 10, 24, 40, 580, DateTimeKind.Local).AddTicks(3134) });

            migrationBuilder.UpdateData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Created", "Description", "LengthInKm", "Name", "RegionID", "Updated" },
                values: new object[] { new DateTime(2024, 5, 16, 10, 24, 40, 580, DateTimeKind.Local).AddTicks(3140), "This is a beautiful walk in the forrest", 10.5, "Great forrest walk", 1, new DateTime(2024, 5, 16, 10, 24, 40, 580, DateTimeKind.Local).AddTicks(3143) });

            migrationBuilder.UpdateData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "Created", "Description", "LengthInKm", "Name", "RegionID", "Updated" },
                values: new object[] { new DateTime(2024, 5, 16, 10, 24, 40, 580, DateTimeKind.Local).AddTicks(3148), "This is a beautiful walk by a lake", 15.5, "Great lake walk", 1, new DateTime(2024, 5, 16, 10, 24, 40, 580, DateTimeKind.Local).AddTicks(3150) });

            migrationBuilder.UpdateData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "Created", "Description", "LengthInKm", "Name", "RegionID", "Updated" },
                values: new object[] { new DateTime(2024, 5, 16, 10, 24, 40, 580, DateTimeKind.Local).AddTicks(3154), "This is a beautiful walk in the mountains", 18.5, "Great mountain walk", 2, new DateTime(2024, 5, 16, 10, 24, 40, 580, DateTimeKind.Local).AddTicks(3156) });
        }
    }
}
