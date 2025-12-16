using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PlatformaBranzowaTI.Migrations
{
    public partial class Dane : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "SensorReports",
                columns: new[] { "Id", "Humidity", "Notes", "Temperature", "Timestamp" },
                values: new object[,]
                {
                    { 1, 45.200000000000003, "Normalna praca", 21.5, new DateTime(2025, 12, 16, 6, 57, 43, 68, DateTimeKind.Local).AddTicks(3606) },
                    { 2, 44.799999999999997, "Stabilne warunki", 21.699999999999999, new DateTime(2025, 12, 16, 7, 7, 43, 68, DateTimeKind.Local).AddTicks(3721) },
                    { 3, 44.100000000000001, null, 22.0, new DateTime(2025, 12, 16, 7, 17, 43, 68, DateTimeKind.Local).AddTicks(3735) },
                    { 4, 43.899999999999999, "Lekki wzrost temperatury", 22.300000000000001, new DateTime(2025, 12, 16, 7, 27, 43, 68, DateTimeKind.Local).AddTicks(3747) },
                    { 5, 43.5, null, 22.100000000000001, new DateTime(2025, 12, 16, 7, 37, 43, 68, DateTimeKind.Local).AddTicks(3757) },
                    { 6, 43.0, null, 21.899999999999999, new DateTime(2025, 12, 16, 7, 47, 43, 68, DateTimeKind.Local).AddTicks(3780) },
                    { 7, 42.799999999999997, "Spadek wilgotności", 21.600000000000001, new DateTime(2025, 12, 16, 7, 57, 43, 68, DateTimeKind.Local).AddTicks(3792) },
                    { 8, 42.5, null, 21.399999999999999, new DateTime(2025, 12, 16, 8, 7, 43, 68, DateTimeKind.Local).AddTicks(3804) },
                    { 9, 42.0, null, 21.199999999999999, new DateTime(2025, 12, 16, 8, 17, 43, 68, DateTimeKind.Local).AddTicks(3815) },
                    { 10, 41.799999999999997, "Stabilizacja", 21.0, new DateTime(2025, 12, 16, 8, 27, 43, 68, DateTimeKind.Local).AddTicks(3831) },
                    { 11, 41.5, null, 20.899999999999999, new DateTime(2025, 12, 16, 8, 37, 43, 68, DateTimeKind.Local).AddTicks(3842) },
                    { 12, 41.200000000000003, null, 20.800000000000001, new DateTime(2025, 12, 16, 8, 47, 43, 68, DateTimeKind.Local).AddTicks(3855) },
                    { 13, 41.0, "Warunki optymalne", 20.699999999999999, new DateTime(2025, 12, 16, 8, 57, 43, 68, DateTimeKind.Local).AddTicks(3866) },
                    { 14, 40.799999999999997, null, 20.899999999999999, new DateTime(2025, 12, 16, 9, 7, 43, 68, DateTimeKind.Local).AddTicks(3877) },
                    { 15, 40.5, null, 21.100000000000001, new DateTime(2025, 12, 16, 9, 17, 43, 68, DateTimeKind.Local).AddTicks(3889) },
                    { 16, 40.200000000000003, "Wzrost temperatury", 21.399999999999999, new DateTime(2025, 12, 16, 9, 27, 43, 68, DateTimeKind.Local).AddTicks(3900) },
                    { 17, 40.0, null, 21.800000000000001, new DateTime(2025, 12, 16, 9, 37, 43, 68, DateTimeKind.Local).AddTicks(3910) },
                    { 18, 39.799999999999997, null, 22.199999999999999, new DateTime(2025, 12, 16, 9, 47, 43, 68, DateTimeKind.Local).AddTicks(3927) },
                    { 19, 39.5, "Cieplej niż zwykle", 22.5, new DateTime(2025, 12, 16, 9, 57, 43, 68, DateTimeKind.Local).AddTicks(3940) },
                    { 20, 39.200000000000003, null, 22.800000000000001, new DateTime(2025, 12, 16, 10, 7, 43, 68, DateTimeKind.Local).AddTicks(3951) },
                    { 21, 39.0, null, 23.0, new DateTime(2025, 12, 16, 10, 17, 43, 68, DateTimeKind.Local).AddTicks(3962) },
                    { 22, 38.700000000000003, "Niska wilgotność", 23.199999999999999, new DateTime(2025, 12, 16, 10, 27, 43, 68, DateTimeKind.Local).AddTicks(3973) },
                    { 23, 38.5, null, 23.399999999999999, new DateTime(2025, 12, 16, 10, 37, 43, 68, DateTimeKind.Local).AddTicks(3984) },
                    { 24, 38.299999999999997, null, 23.600000000000001, new DateTime(2025, 12, 16, 10, 47, 43, 68, DateTimeKind.Local).AddTicks(3998) },
                    { 25, 38.0, "Zbliża się próg ostrzegawczy", 23.800000000000001, new DateTime(2025, 12, 16, 10, 57, 43, 68, DateTimeKind.Local).AddTicks(4009) },
                    { 26, 37.799999999999997, null, 24.0, new DateTime(2025, 12, 16, 11, 7, 43, 68, DateTimeKind.Local).AddTicks(4020) },
                    { 27, 37.5, null, 24.199999999999999, new DateTime(2025, 12, 16, 11, 17, 43, 68, DateTimeKind.Local).AddTicks(4031) },
                    { 28, 37.200000000000003, "Wysoka temperatura", 24.399999999999999, new DateTime(2025, 12, 16, 11, 27, 43, 68, DateTimeKind.Local).AddTicks(4042) },
                    { 29, 37.0, null, 24.600000000000001, new DateTime(2025, 12, 16, 11, 37, 43, 68, DateTimeKind.Local).AddTicks(4052) },
                    { 30, 36.799999999999997, "Ostatni odczyt", 24.800000000000001, new DateTime(2025, 12, 16, 11, 47, 43, 68, DateTimeKind.Local).AddTicks(4064) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SensorReports",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SensorReports",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SensorReports",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "SensorReports",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "SensorReports",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "SensorReports",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "SensorReports",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "SensorReports",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "SensorReports",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "SensorReports",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "SensorReports",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "SensorReports",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "SensorReports",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "SensorReports",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "SensorReports",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "SensorReports",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "SensorReports",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "SensorReports",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "SensorReports",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "SensorReports",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "SensorReports",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "SensorReports",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "SensorReports",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "SensorReports",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "SensorReports",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "SensorReports",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "SensorReports",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "SensorReports",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "SensorReports",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "SensorReports",
                keyColumn: "Id",
                keyValue: 30);
        }
    }
}
