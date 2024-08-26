using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NZWalksApi.Data.Migrations
{
    /// <inheritdoc />
    public partial class Foo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "BeautyGrade", "Created", "Updated" },
                values: new object[] { 1, new DateTime(2024, 8, 26, 14, 23, 53, 882, DateTimeKind.Local).AddTicks(8761), new DateTime(2024, 8, 26, 14, 23, 53, 882, DateTimeKind.Local).AddTicks(8810) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "BeautyGrade", "Created", "Updated" },
                values: new object[] { 3, new DateTime(2024, 8, 26, 14, 23, 53, 882, DateTimeKind.Local).AddTicks(8818), new DateTime(2024, 8, 26, 14, 23, 53, 882, DateTimeKind.Local).AddTicks(8819) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "BeautyGrade", "Created", "Updated" },
                values: new object[] { 3, new DateTime(2024, 8, 26, 14, 23, 53, 882, DateTimeKind.Local).AddTicks(8821), new DateTime(2024, 8, 26, 14, 23, 53, 882, DateTimeKind.Local).AddTicks(8822) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2024, 8, 26, 14, 23, 53, 882, DateTimeKind.Local).AddTicks(8825), new DateTime(2024, 8, 26, 14, 23, 53, 882, DateTimeKind.Local).AddTicks(8826) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "BeautyGrade", "Created", "Updated" },
                values: new object[] { 3, new DateTime(2024, 8, 26, 14, 23, 53, 882, DateTimeKind.Local).AddTicks(8829), new DateTime(2024, 8, 26, 14, 23, 53, 882, DateTimeKind.Local).AddTicks(8830) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "BeautyGrade", "Created", "Updated" },
                values: new object[] { 2, new DateTime(2024, 8, 26, 14, 23, 53, 882, DateTimeKind.Local).AddTicks(8834), new DateTime(2024, 8, 26, 14, 23, 53, 882, DateTimeKind.Local).AddTicks(8835) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "BeautyGrade", "Created", "Updated" },
                values: new object[] { 1, new DateTime(2024, 8, 26, 14, 23, 53, 882, DateTimeKind.Local).AddTicks(8836), new DateTime(2024, 8, 26, 14, 23, 53, 882, DateTimeKind.Local).AddTicks(8837) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2024, 8, 26, 14, 23, 53, 882, DateTimeKind.Local).AddTicks(8839), new DateTime(2024, 8, 26, 14, 23, 53, 882, DateTimeKind.Local).AddTicks(8839) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "BeautyGrade", "Created", "Updated" },
                values: new object[] { 3, new DateTime(2024, 8, 26, 14, 23, 53, 882, DateTimeKind.Local).AddTicks(8841), new DateTime(2024, 8, 26, 14, 23, 53, 882, DateTimeKind.Local).AddTicks(8842) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "BeautyGrade", "Created", "Updated" },
                values: new object[] { 0, new DateTime(2024, 8, 26, 14, 23, 53, 882, DateTimeKind.Local).AddTicks(8846), new DateTime(2024, 8, 26, 14, 23, 53, 882, DateTimeKind.Local).AddTicks(8847) });

            migrationBuilder.UpdateData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Created", "LengthInKm", "RegionID", "Updated" },
                values: new object[] { new DateTime(2024, 8, 26, 14, 23, 53, 882, DateTimeKind.Local).AddTicks(8961), 13.0, 9, new DateTime(2024, 8, 26, 14, 23, 53, 882, DateTimeKind.Local).AddTicks(8963) });

            migrationBuilder.UpdateData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Created", "LengthInKm", "RegionID", "Updated" },
                values: new object[] { new DateTime(2024, 8, 26, 14, 23, 53, 882, DateTimeKind.Local).AddTicks(8967), 17.0, 6, new DateTime(2024, 8, 26, 14, 23, 53, 882, DateTimeKind.Local).AddTicks(8968) });

            migrationBuilder.UpdateData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "Created", "LengthInKm", "RegionID", "Updated" },
                values: new object[] { new DateTime(2024, 8, 26, 14, 23, 53, 882, DateTimeKind.Local).AddTicks(8970), 7.0, 3, new DateTime(2024, 8, 26, 14, 23, 53, 882, DateTimeKind.Local).AddTicks(8971) });

            migrationBuilder.UpdateData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "Created", "LengthInKm", "RegionID", "Updated" },
                values: new object[] { new DateTime(2024, 8, 26, 14, 23, 53, 882, DateTimeKind.Local).AddTicks(8973), 12.0, 1, new DateTime(2024, 8, 26, 14, 23, 53, 882, DateTimeKind.Local).AddTicks(8974) });

            migrationBuilder.UpdateData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "Created", "LengthInKm", "RegionID", "Updated" },
                values: new object[] { new DateTime(2024, 8, 26, 14, 23, 53, 882, DateTimeKind.Local).AddTicks(8976), 12.0, 5, new DateTime(2024, 8, 26, 14, 23, 53, 882, DateTimeKind.Local).AddTicks(8976) });

            migrationBuilder.UpdateData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "Created", "RegionID", "Updated" },
                values: new object[] { new DateTime(2024, 8, 26, 14, 23, 53, 882, DateTimeKind.Local).AddTicks(9003), 1, new DateTime(2024, 8, 26, 14, 23, 53, 882, DateTimeKind.Local).AddTicks(9004) });

            migrationBuilder.UpdateData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "Created", "LengthInKm", "RegionID", "Updated" },
                values: new object[] { new DateTime(2024, 8, 26, 14, 23, 53, 882, DateTimeKind.Local).AddTicks(9006), 4.0, 10, new DateTime(2024, 8, 26, 14, 23, 53, 882, DateTimeKind.Local).AddTicks(9006) });

            migrationBuilder.UpdateData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "Created", "LengthInKm", "RegionID", "Updated" },
                values: new object[] { new DateTime(2024, 8, 26, 14, 23, 53, 882, DateTimeKind.Local).AddTicks(9008), 4.0, 9, new DateTime(2024, 8, 26, 14, 23, 53, 882, DateTimeKind.Local).AddTicks(9009) });

            migrationBuilder.UpdateData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "Created", "LengthInKm", "RegionID", "Updated" },
                values: new object[] { new DateTime(2024, 8, 26, 14, 23, 53, 882, DateTimeKind.Local).AddTicks(9011), 9.0, 3, new DateTime(2024, 8, 26, 14, 23, 53, 882, DateTimeKind.Local).AddTicks(9012) });

            migrationBuilder.UpdateData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "Created", "LengthInKm", "RegionID", "Updated" },
                values: new object[] { new DateTime(2024, 8, 26, 14, 23, 53, 882, DateTimeKind.Local).AddTicks(9015), 13.0, 10, new DateTime(2024, 8, 26, 14, 23, 53, 882, DateTimeKind.Local).AddTicks(9016) });

            migrationBuilder.UpdateData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2024, 8, 26, 14, 23, 53, 882, DateTimeKind.Local).AddTicks(9018), new DateTime(2024, 8, 26, 14, 23, 53, 882, DateTimeKind.Local).AddTicks(9018) });

            migrationBuilder.UpdateData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "Created", "LengthInKm", "RegionID", "Updated" },
                values: new object[] { new DateTime(2024, 8, 26, 14, 23, 53, 882, DateTimeKind.Local).AddTicks(9020), 15.0, 6, new DateTime(2024, 8, 26, 14, 23, 53, 882, DateTimeKind.Local).AddTicks(9021) });

            migrationBuilder.UpdateData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "Created", "LengthInKm", "RegionID", "Updated" },
                values: new object[] { new DateTime(2024, 8, 26, 14, 23, 53, 882, DateTimeKind.Local).AddTicks(9023), 15.0, 2, new DateTime(2024, 8, 26, 14, 23, 53, 882, DateTimeKind.Local).AddTicks(9024) });

            migrationBuilder.UpdateData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "Created", "LengthInKm", "RegionID", "Updated" },
                values: new object[] { new DateTime(2024, 8, 26, 14, 23, 53, 882, DateTimeKind.Local).AddTicks(9026), 10.0, 7, new DateTime(2024, 8, 26, 14, 23, 53, 882, DateTimeKind.Local).AddTicks(9026) });

            migrationBuilder.UpdateData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "Created", "LengthInKm", "RegionID", "Updated" },
                values: new object[] { new DateTime(2024, 8, 26, 14, 23, 53, 882, DateTimeKind.Local).AddTicks(9028), 9.0, 8, new DateTime(2024, 8, 26, 14, 23, 53, 882, DateTimeKind.Local).AddTicks(9029) });

            migrationBuilder.UpdateData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "Created", "LengthInKm", "RegionID", "Updated" },
                values: new object[] { new DateTime(2024, 8, 26, 14, 23, 53, 882, DateTimeKind.Local).AddTicks(9031), 13.0, 1, new DateTime(2024, 8, 26, 14, 23, 53, 882, DateTimeKind.Local).AddTicks(9031) });

            migrationBuilder.UpdateData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "Created", "LengthInKm", "Updated" },
                values: new object[] { new DateTime(2024, 8, 26, 14, 23, 53, 882, DateTimeKind.Local).AddTicks(9033), 9.0, new DateTime(2024, 8, 26, 14, 23, 53, 882, DateTimeKind.Local).AddTicks(9034) });

            migrationBuilder.UpdateData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "Created", "LengthInKm", "RegionID", "Updated" },
                values: new object[] { new DateTime(2024, 8, 26, 14, 23, 53, 882, DateTimeKind.Local).AddTicks(9037), 2.0, 1, new DateTime(2024, 8, 26, 14, 23, 53, 882, DateTimeKind.Local).AddTicks(9038) });

            migrationBuilder.UpdateData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "Created", "LengthInKm", "Updated" },
                values: new object[] { new DateTime(2024, 8, 26, 14, 23, 53, 882, DateTimeKind.Local).AddTicks(9040), 9.0, new DateTime(2024, 8, 26, 14, 23, 53, 882, DateTimeKind.Local).AddTicks(9040) });

            migrationBuilder.UpdateData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "Created", "LengthInKm", "Updated" },
                values: new object[] { new DateTime(2024, 8, 26, 14, 23, 53, 882, DateTimeKind.Local).AddTicks(9042), 18.0, new DateTime(2024, 8, 26, 14, 23, 53, 882, DateTimeKind.Local).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "Created", "LengthInKm", "RegionID", "Updated" },
                values: new object[] { new DateTime(2024, 8, 26, 14, 23, 53, 882, DateTimeKind.Local).AddTicks(9045), 6.0, 10, new DateTime(2024, 8, 26, 14, 23, 53, 882, DateTimeKind.Local).AddTicks(9045) });

            migrationBuilder.UpdateData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 22,
                columns: new[] { "Created", "LengthInKm", "Updated" },
                values: new object[] { new DateTime(2024, 8, 26, 14, 23, 53, 882, DateTimeKind.Local).AddTicks(9047), 10.0, new DateTime(2024, 8, 26, 14, 23, 53, 882, DateTimeKind.Local).AddTicks(9048) });

            migrationBuilder.UpdateData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 23,
                columns: new[] { "Created", "LengthInKm", "RegionID", "Updated" },
                values: new object[] { new DateTime(2024, 8, 26, 14, 23, 53, 882, DateTimeKind.Local).AddTicks(9050), 10.0, 9, new DateTime(2024, 8, 26, 14, 23, 53, 882, DateTimeKind.Local).AddTicks(9051) });

            migrationBuilder.UpdateData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 24,
                columns: new[] { "Created", "LengthInKm", "RegionID", "Updated" },
                values: new object[] { new DateTime(2024, 8, 26, 14, 23, 53, 882, DateTimeKind.Local).AddTicks(9052), 11.0, 1, new DateTime(2024, 8, 26, 14, 23, 53, 882, DateTimeKind.Local).AddTicks(9053) });

            migrationBuilder.UpdateData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 25,
                columns: new[] { "Created", "LengthInKm", "Updated" },
                values: new object[] { new DateTime(2024, 8, 26, 14, 23, 53, 882, DateTimeKind.Local).AddTicks(9055), 4.0, new DateTime(2024, 8, 26, 14, 23, 53, 882, DateTimeKind.Local).AddTicks(9056) });

            migrationBuilder.UpdateData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 26,
                columns: new[] { "Created", "LengthInKm", "RegionID", "Updated" },
                values: new object[] { new DateTime(2024, 8, 26, 14, 23, 53, 882, DateTimeKind.Local).AddTicks(9057), 12.0, 3, new DateTime(2024, 8, 26, 14, 23, 53, 882, DateTimeKind.Local).AddTicks(9058) });

            migrationBuilder.UpdateData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 27,
                columns: new[] { "Created", "LengthInKm", "RegionID", "Updated" },
                values: new object[] { new DateTime(2024, 8, 26, 14, 23, 53, 882, DateTimeKind.Local).AddTicks(9060), 10.0, 6, new DateTime(2024, 8, 26, 14, 23, 53, 882, DateTimeKind.Local).AddTicks(9061) });

            migrationBuilder.UpdateData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 28,
                columns: new[] { "Created", "LengthInKm", "RegionID", "Updated" },
                values: new object[] { new DateTime(2024, 8, 26, 14, 23, 53, 882, DateTimeKind.Local).AddTicks(9062), 12.0, 3, new DateTime(2024, 8, 26, 14, 23, 53, 882, DateTimeKind.Local).AddTicks(9063) });

            migrationBuilder.UpdateData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 29,
                columns: new[] { "Created", "LengthInKm", "RegionID", "Updated" },
                values: new object[] { new DateTime(2024, 8, 26, 14, 23, 53, 882, DateTimeKind.Local).AddTicks(9065), 8.0, 8, new DateTime(2024, 8, 26, 14, 23, 53, 882, DateTimeKind.Local).AddTicks(9066) });

            migrationBuilder.UpdateData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 30,
                columns: new[] { "Created", "LengthInKm", "Updated" },
                values: new object[] { new DateTime(2024, 8, 26, 14, 23, 53, 882, DateTimeKind.Local).AddTicks(9068), 10.0, new DateTime(2024, 8, 26, 14, 23, 53, 882, DateTimeKind.Local).AddTicks(9068) });

            migrationBuilder.UpdateData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 31,
                columns: new[] { "Created", "LengthInKm", "RegionID", "Updated" },
                values: new object[] { new DateTime(2024, 8, 26, 14, 23, 53, 882, DateTimeKind.Local).AddTicks(9070), 13.0, 4, new DateTime(2024, 8, 26, 14, 23, 53, 882, DateTimeKind.Local).AddTicks(9071) });

            migrationBuilder.UpdateData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 32,
                columns: new[] { "Created", "LengthInKm", "RegionID", "Updated" },
                values: new object[] { new DateTime(2024, 8, 26, 14, 23, 53, 882, DateTimeKind.Local).AddTicks(9073), 17.0, 9, new DateTime(2024, 8, 26, 14, 23, 53, 882, DateTimeKind.Local).AddTicks(9074) });

            migrationBuilder.UpdateData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 33,
                columns: new[] { "Created", "LengthInKm", "Updated" },
                values: new object[] { new DateTime(2024, 8, 26, 14, 23, 53, 882, DateTimeKind.Local).AddTicks(9075), 13.0, new DateTime(2024, 8, 26, 14, 23, 53, 882, DateTimeKind.Local).AddTicks(9076) });

            migrationBuilder.UpdateData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 34,
                columns: new[] { "Created", "LengthInKm", "RegionID", "Updated" },
                values: new object[] { new DateTime(2024, 8, 26, 14, 23, 53, 882, DateTimeKind.Local).AddTicks(9079), 14.0, 4, new DateTime(2024, 8, 26, 14, 23, 53, 882, DateTimeKind.Local).AddTicks(9080) });

            migrationBuilder.UpdateData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 35,
                columns: new[] { "Created", "LengthInKm", "RegionID", "Updated" },
                values: new object[] { new DateTime(2024, 8, 26, 14, 23, 53, 882, DateTimeKind.Local).AddTicks(9081), 17.0, 9, new DateTime(2024, 8, 26, 14, 23, 53, 882, DateTimeKind.Local).AddTicks(9082) });

            migrationBuilder.UpdateData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 36,
                columns: new[] { "Created", "LengthInKm", "RegionID", "Updated" },
                values: new object[] { new DateTime(2024, 8, 26, 14, 23, 53, 882, DateTimeKind.Local).AddTicks(9084), 2.0, 6, new DateTime(2024, 8, 26, 14, 23, 53, 882, DateTimeKind.Local).AddTicks(9084) });

            migrationBuilder.UpdateData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 37,
                columns: new[] { "Created", "LengthInKm", "RegionID", "Updated" },
                values: new object[] { new DateTime(2024, 8, 26, 14, 23, 53, 882, DateTimeKind.Local).AddTicks(9086), 2.0, 4, new DateTime(2024, 8, 26, 14, 23, 53, 882, DateTimeKind.Local).AddTicks(9087) });

            migrationBuilder.UpdateData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 38,
                columns: new[] { "Created", "LengthInKm", "RegionID", "Updated" },
                values: new object[] { new DateTime(2024, 8, 26, 14, 23, 53, 882, DateTimeKind.Local).AddTicks(9089), 17.0, 1, new DateTime(2024, 8, 26, 14, 23, 53, 882, DateTimeKind.Local).AddTicks(9089) });

            migrationBuilder.UpdateData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 39,
                columns: new[] { "Created", "LengthInKm", "RegionID", "Updated" },
                values: new object[] { new DateTime(2024, 8, 26, 14, 23, 53, 882, DateTimeKind.Local).AddTicks(9091), 10.0, 3, new DateTime(2024, 8, 26, 14, 23, 53, 882, DateTimeKind.Local).AddTicks(9092) });

            migrationBuilder.UpdateData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 40,
                columns: new[] { "Created", "LengthInKm", "RegionID", "Updated" },
                values: new object[] { new DateTime(2024, 8, 26, 14, 23, 53, 882, DateTimeKind.Local).AddTicks(9094), 8.0, 7, new DateTime(2024, 8, 26, 14, 23, 53, 882, DateTimeKind.Local).AddTicks(9095) });

            migrationBuilder.UpdateData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 41,
                columns: new[] { "Created", "LengthInKm", "RegionID", "Updated" },
                values: new object[] { new DateTime(2024, 8, 26, 14, 23, 53, 882, DateTimeKind.Local).AddTicks(9096), 18.0, 1, new DateTime(2024, 8, 26, 14, 23, 53, 882, DateTimeKind.Local).AddTicks(9097) });

            migrationBuilder.UpdateData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 42,
                columns: new[] { "Created", "LengthInKm", "RegionID", "Updated" },
                values: new object[] { new DateTime(2024, 8, 26, 14, 23, 53, 882, DateTimeKind.Local).AddTicks(9099), 13.0, 1, new DateTime(2024, 8, 26, 14, 23, 53, 882, DateTimeKind.Local).AddTicks(9100) });

            migrationBuilder.UpdateData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 43,
                columns: new[] { "Created", "LengthInKm", "RegionID", "Updated" },
                values: new object[] { new DateTime(2024, 8, 26, 14, 23, 53, 882, DateTimeKind.Local).AddTicks(9102), 9.0, 8, new DateTime(2024, 8, 26, 14, 23, 53, 882, DateTimeKind.Local).AddTicks(9102) });

            migrationBuilder.UpdateData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 44,
                columns: new[] { "Created", "LengthInKm", "RegionID", "Updated" },
                values: new object[] { new DateTime(2024, 8, 26, 14, 23, 53, 882, DateTimeKind.Local).AddTicks(9104), 14.0, 2, new DateTime(2024, 8, 26, 14, 23, 53, 882, DateTimeKind.Local).AddTicks(9105) });

            migrationBuilder.UpdateData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 45,
                columns: new[] { "Created", "LengthInKm", "RegionID", "Updated" },
                values: new object[] { new DateTime(2024, 8, 26, 14, 23, 53, 882, DateTimeKind.Local).AddTicks(9121), 14.0, 5, new DateTime(2024, 8, 26, 14, 23, 53, 882, DateTimeKind.Local).AddTicks(9122) });

            migrationBuilder.UpdateData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 46,
                columns: new[] { "Created", "LengthInKm", "RegionID", "Updated" },
                values: new object[] { new DateTime(2024, 8, 26, 14, 23, 53, 882, DateTimeKind.Local).AddTicks(9124), 10.0, 8, new DateTime(2024, 8, 26, 14, 23, 53, 882, DateTimeKind.Local).AddTicks(9125) });

            migrationBuilder.UpdateData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 47,
                columns: new[] { "Created", "LengthInKm", "RegionID", "Updated" },
                values: new object[] { new DateTime(2024, 8, 26, 14, 23, 53, 882, DateTimeKind.Local).AddTicks(9127), 2.0, 2, new DateTime(2024, 8, 26, 14, 23, 53, 882, DateTimeKind.Local).AddTicks(9128) });

            migrationBuilder.UpdateData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 48,
                columns: new[] { "Created", "LengthInKm", "RegionID", "Updated" },
                values: new object[] { new DateTime(2024, 8, 26, 14, 23, 53, 882, DateTimeKind.Local).AddTicks(9130), 7.0, 1, new DateTime(2024, 8, 26, 14, 23, 53, 882, DateTimeKind.Local).AddTicks(9131) });

            migrationBuilder.UpdateData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 49,
                columns: new[] { "Created", "LengthInKm", "RegionID", "Updated" },
                values: new object[] { new DateTime(2024, 8, 26, 14, 23, 53, 882, DateTimeKind.Local).AddTicks(9133), 14.0, 2, new DateTime(2024, 8, 26, 14, 23, 53, 882, DateTimeKind.Local).AddTicks(9133) });

            migrationBuilder.UpdateData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 50,
                columns: new[] { "Created", "LengthInKm", "RegionID", "Updated" },
                values: new object[] { new DateTime(2024, 8, 26, 14, 23, 53, 882, DateTimeKind.Local).AddTicks(9135), 11.0, 6, new DateTime(2024, 8, 26, 14, 23, 53, 882, DateTimeKind.Local).AddTicks(9136) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "BeautyGrade", "Created", "Updated" },
                values: new object[] { 3, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7331), new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7368) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "BeautyGrade", "Created", "Updated" },
                values: new object[] { 2, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7375), new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7376) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "BeautyGrade", "Created", "Updated" },
                values: new object[] { 1, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7378), new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7379) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7382), new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7383) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "BeautyGrade", "Created", "Updated" },
                values: new object[] { 1, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7386), new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7387) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "BeautyGrade", "Created", "Updated" },
                values: new object[] { 0, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7392), new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7393) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "BeautyGrade", "Created", "Updated" },
                values: new object[] { 0, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7395), new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7396) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7401), new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7402) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "BeautyGrade", "Created", "Updated" },
                values: new object[] { 1, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7404), new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7405) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "BeautyGrade", "Created", "Updated" },
                values: new object[] { 3, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7409), new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7410) });

            migrationBuilder.UpdateData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Created", "LengthInKm", "RegionID", "Updated" },
                values: new object[] { new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7528), 17.0, 10, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7530) });

            migrationBuilder.UpdateData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Created", "LengthInKm", "RegionID", "Updated" },
                values: new object[] { new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7533), 10.0, 3, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7534) });

            migrationBuilder.UpdateData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "Created", "LengthInKm", "RegionID", "Updated" },
                values: new object[] { new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7537), 6.0, 5, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7538) });

            migrationBuilder.UpdateData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "Created", "LengthInKm", "RegionID", "Updated" },
                values: new object[] { new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7540), 9.0, 10, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7541) });

            migrationBuilder.UpdateData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "Created", "LengthInKm", "RegionID", "Updated" },
                values: new object[] { new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7543), 14.0, 2, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7544) });

            migrationBuilder.UpdateData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "Created", "RegionID", "Updated" },
                values: new object[] { new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7547), 7, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7548) });

            migrationBuilder.UpdateData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "Created", "LengthInKm", "RegionID", "Updated" },
                values: new object[] { new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7550), 12.0, 3, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7551) });

            migrationBuilder.UpdateData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "Created", "LengthInKm", "RegionID", "Updated" },
                values: new object[] { new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7554), 7.0, 2, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7555) });

            migrationBuilder.UpdateData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "Created", "LengthInKm", "RegionID", "Updated" },
                values: new object[] { new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7557), 6.0, 8, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7558) });

            migrationBuilder.UpdateData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "Created", "LengthInKm", "RegionID", "Updated" },
                values: new object[] { new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7604), 4.0, 1, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7606) });

            migrationBuilder.UpdateData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7609), new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7610) });

            migrationBuilder.UpdateData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "Created", "LengthInKm", "RegionID", "Updated" },
                values: new object[] { new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7613), 14.0, 8, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7614) });

            migrationBuilder.UpdateData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "Created", "LengthInKm", "RegionID", "Updated" },
                values: new object[] { new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7616), 5.0, 3, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7617) });

            migrationBuilder.UpdateData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "Created", "LengthInKm", "RegionID", "Updated" },
                values: new object[] { new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7619), 18.0, 5, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7621) });

            migrationBuilder.UpdateData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "Created", "LengthInKm", "RegionID", "Updated" },
                values: new object[] { new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7623), 12.0, 3, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7624) });

            migrationBuilder.UpdateData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "Created", "LengthInKm", "RegionID", "Updated" },
                values: new object[] { new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7626), 14.0, 8, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7627) });

            migrationBuilder.UpdateData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "Created", "LengthInKm", "Updated" },
                values: new object[] { new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7629), 18.0, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7630) });

            migrationBuilder.UpdateData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "Created", "LengthInKm", "RegionID", "Updated" },
                values: new object[] { new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7635), 10.0, 5, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7636) });

            migrationBuilder.UpdateData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "Created", "LengthInKm", "Updated" },
                values: new object[] { new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7638), 2.0, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7639) });

            migrationBuilder.UpdateData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "Created", "LengthInKm", "Updated" },
                values: new object[] { new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7642), 19.0, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7643) });

            migrationBuilder.UpdateData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "Created", "LengthInKm", "RegionID", "Updated" },
                values: new object[] { new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7645), 3.0, 8, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7647) });

            migrationBuilder.UpdateData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 22,
                columns: new[] { "Created", "LengthInKm", "Updated" },
                values: new object[] { new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7649), 6.0, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7650) });

            migrationBuilder.UpdateData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 23,
                columns: new[] { "Created", "LengthInKm", "RegionID", "Updated" },
                values: new object[] { new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7652), 18.0, 10, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7653) });

            migrationBuilder.UpdateData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 24,
                columns: new[] { "Created", "LengthInKm", "RegionID", "Updated" },
                values: new object[] { new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7655), 19.0, 5, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7656) });

            migrationBuilder.UpdateData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 25,
                columns: new[] { "Created", "LengthInKm", "Updated" },
                values: new object[] { new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7658), 11.0, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7659) });

            migrationBuilder.UpdateData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 26,
                columns: new[] { "Created", "LengthInKm", "RegionID", "Updated" },
                values: new object[] { new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7661), 8.0, 7, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7662) });

            migrationBuilder.UpdateData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 27,
                columns: new[] { "Created", "LengthInKm", "RegionID", "Updated" },
                values: new object[] { new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7665), 11.0, 7, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7666) });

            migrationBuilder.UpdateData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 28,
                columns: new[] { "Created", "LengthInKm", "RegionID", "Updated" },
                values: new object[] { new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7668), 7.0, 5, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7669) });

            migrationBuilder.UpdateData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 29,
                columns: new[] { "Created", "LengthInKm", "RegionID", "Updated" },
                values: new object[] { new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7671), 18.0, 4, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7672) });

            migrationBuilder.UpdateData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 30,
                columns: new[] { "Created", "LengthInKm", "Updated" },
                values: new object[] { new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7675), 12.0, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7676) });

            migrationBuilder.UpdateData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 31,
                columns: new[] { "Created", "LengthInKm", "RegionID", "Updated" },
                values: new object[] { new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7678), 9.0, 8, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 32,
                columns: new[] { "Created", "LengthInKm", "RegionID", "Updated" },
                values: new object[] { new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7681), 13.0, 2, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7682) });

            migrationBuilder.UpdateData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 33,
                columns: new[] { "Created", "LengthInKm", "Updated" },
                values: new object[] { new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7684), 19.0, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7685) });

            migrationBuilder.UpdateData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 34,
                columns: new[] { "Created", "LengthInKm", "RegionID", "Updated" },
                values: new object[] { new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7689), 19.0, 6, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7690) });

            migrationBuilder.UpdateData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 35,
                columns: new[] { "Created", "LengthInKm", "RegionID", "Updated" },
                values: new object[] { new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7692), 7.0, 1, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7693) });

            migrationBuilder.UpdateData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 36,
                columns: new[] { "Created", "LengthInKm", "RegionID", "Updated" },
                values: new object[] { new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7696), 10.0, 9, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7697) });

            migrationBuilder.UpdateData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 37,
                columns: new[] { "Created", "LengthInKm", "RegionID", "Updated" },
                values: new object[] { new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7699), 16.0, 3, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7700) });

            migrationBuilder.UpdateData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 38,
                columns: new[] { "Created", "LengthInKm", "RegionID", "Updated" },
                values: new object[] { new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7702), 3.0, 3, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7703) });

            migrationBuilder.UpdateData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 39,
                columns: new[] { "Created", "LengthInKm", "RegionID", "Updated" },
                values: new object[] { new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7705), 9.0, 2, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7706) });

            migrationBuilder.UpdateData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 40,
                columns: new[] { "Created", "LengthInKm", "RegionID", "Updated" },
                values: new object[] { new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7709), 10.0, 1, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7710) });

            migrationBuilder.UpdateData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 41,
                columns: new[] { "Created", "LengthInKm", "RegionID", "Updated" },
                values: new object[] { new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7712), 13.0, 3, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7713) });

            migrationBuilder.UpdateData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 42,
                columns: new[] { "Created", "LengthInKm", "RegionID", "Updated" },
                values: new object[] { new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7715), 8.0, 3, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7716) });

            migrationBuilder.UpdateData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 43,
                columns: new[] { "Created", "LengthInKm", "RegionID", "Updated" },
                values: new object[] { new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7719), 18.0, 1, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7720) });

            migrationBuilder.UpdateData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 44,
                columns: new[] { "Created", "LengthInKm", "RegionID", "Updated" },
                values: new object[] { new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7722), 11.0, 8, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7723) });

            migrationBuilder.UpdateData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 45,
                columns: new[] { "Created", "LengthInKm", "RegionID", "Updated" },
                values: new object[] { new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7725), 9.0, 3, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7727) });

            migrationBuilder.UpdateData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 46,
                columns: new[] { "Created", "LengthInKm", "RegionID", "Updated" },
                values: new object[] { new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7729), 2.0, 1, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7730) });

            migrationBuilder.UpdateData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 47,
                columns: new[] { "Created", "LengthInKm", "RegionID", "Updated" },
                values: new object[] { new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7732), 19.0, 1, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7733) });

            migrationBuilder.UpdateData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 48,
                columns: new[] { "Created", "LengthInKm", "RegionID", "Updated" },
                values: new object[] { new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7735), 18.0, 9, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7737) });

            migrationBuilder.UpdateData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 49,
                columns: new[] { "Created", "LengthInKm", "RegionID", "Updated" },
                values: new object[] { new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7739), 6.0, 3, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7740) });

            migrationBuilder.UpdateData(
                table: "Walks",
                keyColumn: "ID",
                keyValue: 50,
                columns: new[] { "Created", "LengthInKm", "RegionID", "Updated" },
                values: new object[] { new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7774), 18.0, 3, new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7775) });
        }
    }
}
