using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WeatherForecast.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WeatherForecasts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TemperatureC = table.Column<int>(type: "int", nullable: false),
                    Summary = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeatherForecasts", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "WeatherForecasts",
                columns: new[] { "Id", "Date", "Summary", "TemperatureC" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 14, 17, 10, 25, 91, DateTimeKind.Local).AddTicks(9206), "Mild", 38 },
                    { 28, new DateTime(2023, 11, 30, 17, 10, 25, 113, DateTimeKind.Local).AddTicks(6251), "Bracing", 10 },
                    { 29, new DateTime(2023, 11, 4, 17, 10, 25, 113, DateTimeKind.Local).AddTicks(6254), "Cool", 48 },
                    { 30, new DateTime(2023, 11, 19, 17, 10, 25, 113, DateTimeKind.Local).AddTicks(6257), "Warm", -17 },
                    { 31, new DateTime(2023, 11, 4, 17, 10, 25, 113, DateTimeKind.Local).AddTicks(6260), "Chilly", 30 },
                    { 32, new DateTime(2023, 11, 23, 17, 10, 25, 113, DateTimeKind.Local).AddTicks(6262), "Cool", 21 },
                    { 33, new DateTime(2023, 11, 18, 17, 10, 25, 113, DateTimeKind.Local).AddTicks(6265), "Balmy", 14 },
                    { 34, new DateTime(2023, 11, 4, 17, 10, 25, 113, DateTimeKind.Local).AddTicks(6268), "Chilly", 40 },
                    { 35, new DateTime(2023, 11, 28, 17, 10, 25, 113, DateTimeKind.Local).AddTicks(6270), "Hot", -4 },
                    { 36, new DateTime(2023, 11, 9, 17, 10, 25, 113, DateTimeKind.Local).AddTicks(6272), "Sweltering", -5 },
                    { 37, new DateTime(2023, 11, 25, 17, 10, 25, 113, DateTimeKind.Local).AddTicks(6274), "Freezing", 36 },
                    { 38, new DateTime(2023, 11, 27, 17, 10, 25, 113, DateTimeKind.Local).AddTicks(6277), "Sweltering", -6 },
                    { 39, new DateTime(2023, 11, 4, 17, 10, 25, 113, DateTimeKind.Local).AddTicks(6279), "Cool", 47 },
                    { 40, new DateTime(2023, 11, 11, 17, 10, 25, 113, DateTimeKind.Local).AddTicks(6282), "Warm", 37 },
                    { 41, new DateTime(2023, 12, 6, 17, 10, 25, 113, DateTimeKind.Local).AddTicks(6284), "Balmy", -9 },
                    { 42, new DateTime(2023, 11, 20, 17, 10, 25, 113, DateTimeKind.Local).AddTicks(6286), "Scorching", 37 },
                    { 43, new DateTime(2023, 11, 16, 17, 10, 25, 113, DateTimeKind.Local).AddTicks(6289), "Balmy", 45 },
                    { 44, new DateTime(2023, 11, 18, 17, 10, 25, 113, DateTimeKind.Local).AddTicks(6291), "Warm", 8 },
                    { 45, new DateTime(2023, 12, 8, 17, 10, 25, 113, DateTimeKind.Local).AddTicks(6294), "Balmy", 11 },
                    { 46, new DateTime(2023, 12, 10, 17, 10, 25, 113, DateTimeKind.Local).AddTicks(6296), "Bracing", -17 },
                    { 47, new DateTime(2023, 11, 20, 17, 10, 25, 113, DateTimeKind.Local).AddTicks(6308), "Balmy", 45 },
                    { 48, new DateTime(2023, 11, 25, 17, 10, 25, 113, DateTimeKind.Local).AddTicks(6310), "Chilly", 44 },
                    { 27, new DateTime(2023, 11, 20, 17, 10, 25, 113, DateTimeKind.Local).AddTicks(6249), "Bracing", 14 },
                    { 26, new DateTime(2023, 12, 3, 17, 10, 25, 113, DateTimeKind.Local).AddTicks(6246), "Warm", 54 },
                    { 25, new DateTime(2023, 11, 18, 17, 10, 25, 113, DateTimeKind.Local).AddTicks(6244), "Hot", -6 },
                    { 24, new DateTime(2023, 12, 5, 17, 10, 25, 113, DateTimeKind.Local).AddTicks(6241), "Warm", 24 },
                    { 2, new DateTime(2023, 11, 10, 17, 10, 25, 113, DateTimeKind.Local).AddTicks(6035), "Freezing", 9 },
                    { 3, new DateTime(2023, 11, 9, 17, 10, 25, 113, DateTimeKind.Local).AddTicks(6070), "Balmy", 47 },
                    { 4, new DateTime(2023, 11, 2, 17, 10, 25, 113, DateTimeKind.Local).AddTicks(6075), "Cool", 27 },
                    { 5, new DateTime(2023, 11, 13, 17, 10, 25, 113, DateTimeKind.Local).AddTicks(6077), "Freezing", 31 },
                    { 6, new DateTime(2023, 12, 8, 17, 10, 25, 113, DateTimeKind.Local).AddTicks(6080), "Bracing", -13 },
                    { 7, new DateTime(2023, 11, 16, 17, 10, 25, 113, DateTimeKind.Local).AddTicks(6192), "Balmy", 39 },
                    { 8, new DateTime(2023, 11, 13, 17, 10, 25, 113, DateTimeKind.Local).AddTicks(6196), "Hot", 26 },
                    { 9, new DateTime(2023, 12, 7, 17, 10, 25, 113, DateTimeKind.Local).AddTicks(6199), "Mild", -10 },
                    { 10, new DateTime(2023, 11, 20, 17, 10, 25, 113, DateTimeKind.Local).AddTicks(6205), "Sweltering", 16 },
                    { 11, new DateTime(2023, 11, 22, 17, 10, 25, 113, DateTimeKind.Local).AddTicks(6208), "Hot", 9 },
                    { 49, new DateTime(2023, 11, 23, 17, 10, 25, 113, DateTimeKind.Local).AddTicks(6313), "Mild", 12 },
                    { 12, new DateTime(2023, 11, 25, 17, 10, 25, 113, DateTimeKind.Local).AddTicks(6211), "Chilly", 26 },
                    { 14, new DateTime(2023, 11, 8, 17, 10, 25, 113, DateTimeKind.Local).AddTicks(6217), "Sweltering", -16 },
                    { 15, new DateTime(2023, 11, 13, 17, 10, 25, 113, DateTimeKind.Local).AddTicks(6219), "Chilly", -13 },
                    { 16, new DateTime(2023, 11, 18, 17, 10, 25, 113, DateTimeKind.Local).AddTicks(6222), "Hot", 51 },
                    { 17, new DateTime(2023, 11, 4, 17, 10, 25, 113, DateTimeKind.Local).AddTicks(6224), "Hot", 2 }
                });

            migrationBuilder.InsertData(
                table: "WeatherForecasts",
                columns: new[] { "Id", "Date", "Summary", "TemperatureC" },
                values: new object[,]
                {
                    { 18, new DateTime(2023, 11, 26, 17, 10, 25, 113, DateTimeKind.Local).AddTicks(6226), "Cool", -20 },
                    { 19, new DateTime(2023, 11, 23, 17, 10, 25, 113, DateTimeKind.Local).AddTicks(6229), "Bracing", -18 },
                    { 20, new DateTime(2023, 11, 28, 17, 10, 25, 113, DateTimeKind.Local).AddTicks(6231), "Chilly", 4 },
                    { 21, new DateTime(2023, 11, 26, 17, 10, 25, 113, DateTimeKind.Local).AddTicks(6234), "Mild", 35 },
                    { 22, new DateTime(2023, 12, 5, 17, 10, 25, 113, DateTimeKind.Local).AddTicks(6237), "Chilly", 16 },
                    { 23, new DateTime(2023, 11, 26, 17, 10, 25, 113, DateTimeKind.Local).AddTicks(6239), "Freezing", 32 },
                    { 13, new DateTime(2023, 11, 15, 17, 10, 25, 113, DateTimeKind.Local).AddTicks(6214), "Hot", 20 },
                    { 50, new DateTime(2023, 11, 16, 17, 10, 25, 113, DateTimeKind.Local).AddTicks(6316), "Balmy", 15 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WeatherForecasts");
        }
    }
}
