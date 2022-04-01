using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GBCSportingWeb.Migrations
{
    public partial class SeedDataForRegistrati : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentId",
                keyValue: 1,
                columns: new[] { "DateClosed", "DateOpened" },
                values: new object[] { new DateTime(2022, 3, 24, 18, 6, 56, 145, DateTimeKind.Local).AddTicks(9147), new DateTime(2022, 3, 24, 18, 6, 56, 145, DateTimeKind.Local).AddTicks(9145) });

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentId",
                keyValue: 2,
                columns: new[] { "DateClosed", "DateOpened" },
                values: new object[] { new DateTime(2022, 3, 24, 18, 6, 56, 145, DateTimeKind.Local).AddTicks(9151), new DateTime(2022, 3, 24, 18, 6, 56, 145, DateTimeKind.Local).AddTicks(9149) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "ReleaseDate",
                value: new DateTime(2022, 3, 24, 18, 6, 56, 145, DateTimeKind.Local).AddTicks(9117));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "ReleaseDate",
                value: new DateTime(2022, 3, 24, 18, 6, 56, 145, DateTimeKind.Local).AddTicks(9120));

            migrationBuilder.InsertData(
                table: "Registrations",
                columns: new[] { "Id", "CustomerId", "ProductId" },
                values: new object[] { 2, 2, 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Registrations",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentId",
                keyValue: 1,
                columns: new[] { "DateClosed", "DateOpened" },
                values: new object[] { new DateTime(2022, 3, 24, 18, 4, 36, 502, DateTimeKind.Local).AddTicks(3349), new DateTime(2022, 3, 24, 18, 4, 36, 502, DateTimeKind.Local).AddTicks(3347) });

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentId",
                keyValue: 2,
                columns: new[] { "DateClosed", "DateOpened" },
                values: new object[] { new DateTime(2022, 3, 24, 18, 4, 36, 502, DateTimeKind.Local).AddTicks(3352), new DateTime(2022, 3, 24, 18, 4, 36, 502, DateTimeKind.Local).AddTicks(3351) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "ReleaseDate",
                value: new DateTime(2022, 3, 24, 18, 4, 36, 502, DateTimeKind.Local).AddTicks(3320));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "ReleaseDate",
                value: new DateTime(2022, 3, 24, 18, 4, 36, 502, DateTimeKind.Local).AddTicks(3324));
        }
    }
}
