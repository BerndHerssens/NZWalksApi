using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NZWalksApi.Data.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BeautyGrades",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BeautyGrades", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Regions",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    I = table.Column<int>(type: "int", nullable: false),
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
                table: "BeautyGrades",
                columns: new[] { "ID", "Created", "Name", "Updated" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Awful", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "SlightlyDirty", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Normal", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pretty", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "MrPropreClean", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "ID", "BeautyGrade", "Created", "Description", "I", "Name", "Updated" },
                values: new object[,]
                {
                    { 1, 5, new DateTime(2024, 8, 26, 15, 18, 22, 412, DateTimeKind.Local).AddTicks(1976), "Description for region 1", 0, "Region 1", new DateTime(2024, 8, 26, 15, 18, 22, 412, DateTimeKind.Local).AddTicks(2035) },
                    { 2, 4, new DateTime(2024, 8, 26, 15, 18, 22, 412, DateTimeKind.Local).AddTicks(2041), "Description for region 2", 0, "Region 2", new DateTime(2024, 8, 26, 15, 18, 22, 412, DateTimeKind.Local).AddTicks(2043) },
                    { 3, 5, new DateTime(2024, 8, 26, 15, 18, 22, 412, DateTimeKind.Local).AddTicks(2045), "Description for region 3", 0, "Region 3", new DateTime(2024, 8, 26, 15, 18, 22, 412, DateTimeKind.Local).AddTicks(2046) },
                    { 4, 2, new DateTime(2024, 8, 26, 15, 18, 22, 412, DateTimeKind.Local).AddTicks(2049), "Description for region 4", 0, "Region 4", new DateTime(2024, 8, 26, 15, 18, 22, 412, DateTimeKind.Local).AddTicks(2050) },
                    { 5, 5, new DateTime(2024, 8, 26, 15, 18, 22, 412, DateTimeKind.Local).AddTicks(2053), "Description for region 5", 0, "Region 5", new DateTime(2024, 8, 26, 15, 18, 22, 412, DateTimeKind.Local).AddTicks(2054) },
                    { 6, 2, new DateTime(2024, 8, 26, 15, 18, 22, 412, DateTimeKind.Local).AddTicks(2057), "Description for region 6", 0, "Region 6", new DateTime(2024, 8, 26, 15, 18, 22, 412, DateTimeKind.Local).AddTicks(2058) },
                    { 7, 0, new DateTime(2024, 8, 26, 15, 18, 22, 412, DateTimeKind.Local).AddTicks(2061), "Description for region 7", 0, "Region 7", new DateTime(2024, 8, 26, 15, 18, 22, 412, DateTimeKind.Local).AddTicks(2062) },
                    { 8, 5, new DateTime(2024, 8, 26, 15, 18, 22, 412, DateTimeKind.Local).AddTicks(2064), "Description for region 8", 0, "Region 8", new DateTime(2024, 8, 26, 15, 18, 22, 412, DateTimeKind.Local).AddTicks(2065) },
                    { 9, 1, new DateTime(2024, 8, 26, 15, 18, 22, 412, DateTimeKind.Local).AddTicks(2068), "Description for region 9", 0, "Region 9", new DateTime(2024, 8, 26, 15, 18, 22, 412, DateTimeKind.Local).AddTicks(2069) },
                    { 10, 2, new DateTime(2024, 8, 26, 15, 18, 22, 412, DateTimeKind.Local).AddTicks(2075), "Description for region 10", 0, "Region 10", new DateTime(2024, 8, 26, 15, 18, 22, 412, DateTimeKind.Local).AddTicks(2076) }
                });

            migrationBuilder.InsertData(
                table: "Walks",
                columns: new[] { "ID", "Created", "Description", "LengthInKm", "Name", "RegionID", "Updated" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 8, 26, 15, 18, 22, 412, DateTimeKind.Local).AddTicks(2125), "Description for walk 1", 4.0, "Walk 1", 4, new DateTime(2024, 8, 26, 15, 18, 22, 412, DateTimeKind.Local).AddTicks(2126) },
                    { 2, new DateTime(2024, 8, 26, 15, 18, 22, 412, DateTimeKind.Local).AddTicks(2131), "Description for walk 2", 11.0, "Walk 2", 1, new DateTime(2024, 8, 26, 15, 18, 22, 412, DateTimeKind.Local).AddTicks(2132) },
                    { 3, new DateTime(2024, 8, 26, 15, 18, 22, 412, DateTimeKind.Local).AddTicks(2135), "Description for walk 3", 4.0, "Walk 3", 5, new DateTime(2024, 8, 26, 15, 18, 22, 412, DateTimeKind.Local).AddTicks(2136) },
                    { 4, new DateTime(2024, 8, 26, 15, 18, 22, 412, DateTimeKind.Local).AddTicks(2139), "Description for walk 4", 14.0, "Walk 4", 6, new DateTime(2024, 8, 26, 15, 18, 22, 412, DateTimeKind.Local).AddTicks(2140) },
                    { 5, new DateTime(2024, 8, 26, 15, 18, 22, 412, DateTimeKind.Local).AddTicks(2142), "Description for walk 5", 9.0, "Walk 5", 8, new DateTime(2024, 8, 26, 15, 18, 22, 412, DateTimeKind.Local).AddTicks(2143) },
                    { 6, new DateTime(2024, 8, 26, 15, 18, 22, 412, DateTimeKind.Local).AddTicks(2147), "Description for walk 6", 12.0, "Walk 6", 8, new DateTime(2024, 8, 26, 15, 18, 22, 412, DateTimeKind.Local).AddTicks(2148) },
                    { 7, new DateTime(2024, 8, 26, 15, 18, 22, 412, DateTimeKind.Local).AddTicks(2151), "Description for walk 7", 9.0, "Walk 7", 9, new DateTime(2024, 8, 26, 15, 18, 22, 412, DateTimeKind.Local).AddTicks(2152) },
                    { 8, new DateTime(2024, 8, 26, 15, 18, 22, 412, DateTimeKind.Local).AddTicks(2154), "Description for walk 8", 4.0, "Walk 8", 8, new DateTime(2024, 8, 26, 15, 18, 22, 412, DateTimeKind.Local).AddTicks(2155) },
                    { 9, new DateTime(2024, 8, 26, 15, 18, 22, 412, DateTimeKind.Local).AddTicks(2158), "Description for walk 9", 3.0, "Walk 9", 7, new DateTime(2024, 8, 26, 15, 18, 22, 412, DateTimeKind.Local).AddTicks(2159) },
                    { 10, new DateTime(2024, 8, 26, 15, 18, 22, 412, DateTimeKind.Local).AddTicks(2163), "Description for walk 10", 8.0, "Walk 10", 1, new DateTime(2024, 8, 26, 15, 18, 22, 412, DateTimeKind.Local).AddTicks(2164) },
                    { 11, new DateTime(2024, 8, 26, 15, 18, 22, 412, DateTimeKind.Local).AddTicks(2166), "Description for walk 11", 3.0, "Walk 11", 4, new DateTime(2024, 8, 26, 15, 18, 22, 412, DateTimeKind.Local).AddTicks(2167) },
                    { 12, new DateTime(2024, 8, 26, 15, 18, 22, 412, DateTimeKind.Local).AddTicks(2170), "Description for walk 12", 5.0, "Walk 12", 1, new DateTime(2024, 8, 26, 15, 18, 22, 412, DateTimeKind.Local).AddTicks(2171) },
                    { 13, new DateTime(2024, 8, 26, 15, 18, 22, 412, DateTimeKind.Local).AddTicks(2173), "Description for walk 13", 5.0, "Walk 13", 7, new DateTime(2024, 8, 26, 15, 18, 22, 412, DateTimeKind.Local).AddTicks(2174) },
                    { 14, new DateTime(2024, 8, 26, 15, 18, 22, 412, DateTimeKind.Local).AddTicks(2176), "Description for walk 14", 17.0, "Walk 14", 5, new DateTime(2024, 8, 26, 15, 18, 22, 412, DateTimeKind.Local).AddTicks(2177) },
                    { 15, new DateTime(2024, 8, 26, 15, 18, 22, 412, DateTimeKind.Local).AddTicks(2180), "Description for walk 15", 7.0, "Walk 15", 3, new DateTime(2024, 8, 26, 15, 18, 22, 412, DateTimeKind.Local).AddTicks(2181) },
                    { 16, new DateTime(2024, 8, 26, 15, 18, 22, 412, DateTimeKind.Local).AddTicks(2183), "Description for walk 16", 14.0, "Walk 16", 6, new DateTime(2024, 8, 26, 15, 18, 22, 412, DateTimeKind.Local).AddTicks(2184) },
                    { 17, new DateTime(2024, 8, 26, 15, 18, 22, 412, DateTimeKind.Local).AddTicks(2187), "Description for walk 17", 8.0, "Walk 17", 8, new DateTime(2024, 8, 26, 15, 18, 22, 412, DateTimeKind.Local).AddTicks(2188) },
                    { 18, new DateTime(2024, 8, 26, 15, 18, 22, 412, DateTimeKind.Local).AddTicks(2224), "Description for walk 18", 5.0, "Walk 18", 1, new DateTime(2024, 8, 26, 15, 18, 22, 412, DateTimeKind.Local).AddTicks(2226) },
                    { 19, new DateTime(2024, 8, 26, 15, 18, 22, 412, DateTimeKind.Local).AddTicks(2228), "Description for walk 19", 17.0, "Walk 19", 1, new DateTime(2024, 8, 26, 15, 18, 22, 412, DateTimeKind.Local).AddTicks(2229) },
                    { 20, new DateTime(2024, 8, 26, 15, 18, 22, 412, DateTimeKind.Local).AddTicks(2232), "Description for walk 20", 20.0, "Walk 20", 9, new DateTime(2024, 8, 26, 15, 18, 22, 412, DateTimeKind.Local).AddTicks(2233) },
                    { 21, new DateTime(2024, 8, 26, 15, 18, 22, 412, DateTimeKind.Local).AddTicks(2235), "Description for walk 21", 18.0, "Walk 21", 5, new DateTime(2024, 8, 26, 15, 18, 22, 412, DateTimeKind.Local).AddTicks(2237) },
                    { 22, new DateTime(2024, 8, 26, 15, 18, 22, 412, DateTimeKind.Local).AddTicks(2239), "Description for walk 22", 7.0, "Walk 22", 1, new DateTime(2024, 8, 26, 15, 18, 22, 412, DateTimeKind.Local).AddTicks(2240) },
                    { 23, new DateTime(2024, 8, 26, 15, 18, 22, 412, DateTimeKind.Local).AddTicks(2242), "Description for walk 23", 11.0, "Walk 23", 10, new DateTime(2024, 8, 26, 15, 18, 22, 412, DateTimeKind.Local).AddTicks(2243) },
                    { 24, new DateTime(2024, 8, 26, 15, 18, 22, 412, DateTimeKind.Local).AddTicks(2245), "Description for walk 24", 11.0, "Walk 24", 2, new DateTime(2024, 8, 26, 15, 18, 22, 412, DateTimeKind.Local).AddTicks(2246) },
                    { 25, new DateTime(2024, 8, 26, 15, 18, 22, 412, DateTimeKind.Local).AddTicks(2249), "Description for walk 25", 10.0, "Walk 25", 4, new DateTime(2024, 8, 26, 15, 18, 22, 412, DateTimeKind.Local).AddTicks(2250) },
                    { 26, new DateTime(2024, 8, 26, 15, 18, 22, 412, DateTimeKind.Local).AddTicks(2252), "Description for walk 26", 7.0, "Walk 26", 5, new DateTime(2024, 8, 26, 15, 18, 22, 412, DateTimeKind.Local).AddTicks(2253) },
                    { 27, new DateTime(2024, 8, 26, 15, 18, 22, 412, DateTimeKind.Local).AddTicks(2256), "Description for walk 27", 9.0, "Walk 27", 8, new DateTime(2024, 8, 26, 15, 18, 22, 412, DateTimeKind.Local).AddTicks(2257) },
                    { 28, new DateTime(2024, 8, 26, 15, 18, 22, 412, DateTimeKind.Local).AddTicks(2259), "Description for walk 28", 14.0, "Walk 28", 4, new DateTime(2024, 8, 26, 15, 18, 22, 412, DateTimeKind.Local).AddTicks(2260) },
                    { 29, new DateTime(2024, 8, 26, 15, 18, 22, 412, DateTimeKind.Local).AddTicks(2263), "Description for walk 29", 12.0, "Walk 29", 8, new DateTime(2024, 8, 26, 15, 18, 22, 412, DateTimeKind.Local).AddTicks(2264) },
                    { 30, new DateTime(2024, 8, 26, 15, 18, 22, 412, DateTimeKind.Local).AddTicks(2266), "Description for walk 30", 11.0, "Walk 30", 10, new DateTime(2024, 8, 26, 15, 18, 22, 412, DateTimeKind.Local).AddTicks(2267) },
                    { 31, new DateTime(2024, 8, 26, 15, 18, 22, 412, DateTimeKind.Local).AddTicks(2269), "Description for walk 31", 14.0, "Walk 31", 6, new DateTime(2024, 8, 26, 15, 18, 22, 412, DateTimeKind.Local).AddTicks(2270) },
                    { 32, new DateTime(2024, 8, 26, 15, 18, 22, 412, DateTimeKind.Local).AddTicks(2273), "Description for walk 32", 12.0, "Walk 32", 5, new DateTime(2024, 8, 26, 15, 18, 22, 412, DateTimeKind.Local).AddTicks(2274) },
                    { 33, new DateTime(2024, 8, 26, 15, 18, 22, 412, DateTimeKind.Local).AddTicks(2276), "Description for walk 33", 12.0, "Walk 33", 5, new DateTime(2024, 8, 26, 15, 18, 22, 412, DateTimeKind.Local).AddTicks(2277) },
                    { 34, new DateTime(2024, 8, 26, 15, 18, 22, 412, DateTimeKind.Local).AddTicks(2282), "Description for walk 34", 18.0, "Walk 34", 6, new DateTime(2024, 8, 26, 15, 18, 22, 412, DateTimeKind.Local).AddTicks(2283) },
                    { 35, new DateTime(2024, 8, 26, 15, 18, 22, 412, DateTimeKind.Local).AddTicks(2285), "Description for walk 35", 20.0, "Walk 35", 5, new DateTime(2024, 8, 26, 15, 18, 22, 412, DateTimeKind.Local).AddTicks(2286) },
                    { 36, new DateTime(2024, 8, 26, 15, 18, 22, 412, DateTimeKind.Local).AddTicks(2288), "Description for walk 36", 19.0, "Walk 36", 10, new DateTime(2024, 8, 26, 15, 18, 22, 412, DateTimeKind.Local).AddTicks(2289) },
                    { 37, new DateTime(2024, 8, 26, 15, 18, 22, 412, DateTimeKind.Local).AddTicks(2292), "Description for walk 37", 12.0, "Walk 37", 6, new DateTime(2024, 8, 26, 15, 18, 22, 412, DateTimeKind.Local).AddTicks(2293) },
                    { 38, new DateTime(2024, 8, 26, 15, 18, 22, 412, DateTimeKind.Local).AddTicks(2295), "Description for walk 38", 10.0, "Walk 38", 6, new DateTime(2024, 8, 26, 15, 18, 22, 412, DateTimeKind.Local).AddTicks(2296) },
                    { 39, new DateTime(2024, 8, 26, 15, 18, 22, 412, DateTimeKind.Local).AddTicks(2298), "Description for walk 39", 13.0, "Walk 39", 6, new DateTime(2024, 8, 26, 15, 18, 22, 412, DateTimeKind.Local).AddTicks(2299) },
                    { 40, new DateTime(2024, 8, 26, 15, 18, 22, 412, DateTimeKind.Local).AddTicks(2302), "Description for walk 40", 6.0, "Walk 40", 7, new DateTime(2024, 8, 26, 15, 18, 22, 412, DateTimeKind.Local).AddTicks(2303) },
                    { 41, new DateTime(2024, 8, 26, 15, 18, 22, 412, DateTimeKind.Local).AddTicks(2305), "Description for walk 41", 7.0, "Walk 41", 8, new DateTime(2024, 8, 26, 15, 18, 22, 412, DateTimeKind.Local).AddTicks(2306) },
                    { 42, new DateTime(2024, 8, 26, 15, 18, 22, 412, DateTimeKind.Local).AddTicks(2309), "Description for walk 42", 20.0, "Walk 42", 7, new DateTime(2024, 8, 26, 15, 18, 22, 412, DateTimeKind.Local).AddTicks(2310) },
                    { 43, new DateTime(2024, 8, 26, 15, 18, 22, 412, DateTimeKind.Local).AddTicks(2312), "Description for walk 43", 14.0, "Walk 43", 7, new DateTime(2024, 8, 26, 15, 18, 22, 412, DateTimeKind.Local).AddTicks(2313) },
                    { 44, new DateTime(2024, 8, 26, 15, 18, 22, 412, DateTimeKind.Local).AddTicks(2315), "Description for walk 44", 3.0, "Walk 44", 6, new DateTime(2024, 8, 26, 15, 18, 22, 412, DateTimeKind.Local).AddTicks(2316) },
                    { 45, new DateTime(2024, 8, 26, 15, 18, 22, 412, DateTimeKind.Local).AddTicks(2319), "Description for walk 45", 14.0, "Walk 45", 2, new DateTime(2024, 8, 26, 15, 18, 22, 412, DateTimeKind.Local).AddTicks(2320) },
                    { 46, new DateTime(2024, 8, 26, 15, 18, 22, 412, DateTimeKind.Local).AddTicks(2322), "Description for walk 46", 6.0, "Walk 46", 8, new DateTime(2024, 8, 26, 15, 18, 22, 412, DateTimeKind.Local).AddTicks(2323) },
                    { 47, new DateTime(2024, 8, 26, 15, 18, 22, 412, DateTimeKind.Local).AddTicks(2325), "Description for walk 47", 3.0, "Walk 47", 10, new DateTime(2024, 8, 26, 15, 18, 22, 412, DateTimeKind.Local).AddTicks(2326) },
                    { 48, new DateTime(2024, 8, 26, 15, 18, 22, 412, DateTimeKind.Local).AddTicks(2330), "Description for walk 48", 15.0, "Walk 48", 8, new DateTime(2024, 8, 26, 15, 18, 22, 412, DateTimeKind.Local).AddTicks(2331) },
                    { 49, new DateTime(2024, 8, 26, 15, 18, 22, 412, DateTimeKind.Local).AddTicks(2333), "Description for walk 49", 9.0, "Walk 49", 8, new DateTime(2024, 8, 26, 15, 18, 22, 412, DateTimeKind.Local).AddTicks(2334) },
                    { 50, new DateTime(2024, 8, 26, 15, 18, 22, 412, DateTimeKind.Local).AddTicks(2336), "Description for walk 50", 20.0, "Walk 50", 1, new DateTime(2024, 8, 26, 15, 18, 22, 412, DateTimeKind.Local).AddTicks(2337) }
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
                name: "BeautyGrades");

            migrationBuilder.DropTable(
                name: "Walks");

            migrationBuilder.DropTable(
                name: "Regions");
        }
    }
}
