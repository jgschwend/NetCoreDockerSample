using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Backend.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "WeatherForecasts",
                columns: new[] { "Id", "Date", "Summary", "TemperatureC" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Freezing", 0 },
                    { 2, new DateTime(2020, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bracing", 5 },
                    { 3, new DateTime(2020, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chilly", 10 },
                    { 4, new DateTime(2020, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mild", 15 },
                    { 5, new DateTime(2020, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Warm", 20 },
                    { 6, new DateTime(2020, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Balmy", 25 },
                    { 7, new DateTime(2020, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hot", 30 },
                    { 8, new DateTime(2020, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sweltering", 35 },
                    { 9, new DateTime(2020, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Scorching", 40 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "WeatherForecasts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "WeatherForecasts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "WeatherForecasts",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "WeatherForecasts",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "WeatherForecasts",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "WeatherForecasts",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "WeatherForecasts",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "WeatherForecasts",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "WeatherForecasts",
                keyColumn: "Id",
                keyValue: 9);
        }
    }
}
