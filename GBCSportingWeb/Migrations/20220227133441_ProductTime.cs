using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GBCSportingWeb.Migrations
{
    public partial class ProductTime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentId",
                keyValue: 1,
                columns: new[] { "DateClosed", "DateOpened" },
                values: new object[] { new DateTime(2022, 2, 27, 8, 34, 41, 73, DateTimeKind.Local).AddTicks(5283), new DateTime(2022, 2, 27, 8, 34, 41, 73, DateTimeKind.Local).AddTicks(5282) });

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentId",
                keyValue: 2,
                columns: new[] { "DateClosed", "DateOpened" },
                values: new object[] { new DateTime(2022, 2, 27, 8, 34, 41, 73, DateTimeKind.Local).AddTicks(5286), new DateTime(2022, 2, 27, 8, 34, 41, 73, DateTimeKind.Local).AddTicks(5285) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "ReleaseDate",
                value: new DateTime(2022, 2, 27, 8, 34, 41, 73, DateTimeKind.Local).AddTicks(5258));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "ReleaseDate",
                value: new DateTime(2022, 2, 27, 8, 34, 41, 73, DateTimeKind.Local).AddTicks(5261));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentId",
                keyValue: 1,
                columns: new[] { "DateClosed", "DateOpened" },
                values: new object[] { new DateTime(2022, 2, 26, 10, 57, 36, 653, DateTimeKind.Local).AddTicks(463), new DateTime(2022, 2, 26, 10, 57, 36, 653, DateTimeKind.Local).AddTicks(461) });

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentId",
                keyValue: 2,
                columns: new[] { "DateClosed", "DateOpened" },
                values: new object[] { new DateTime(2022, 2, 26, 10, 57, 36, 653, DateTimeKind.Local).AddTicks(466), new DateTime(2022, 2, 26, 10, 57, 36, 653, DateTimeKind.Local).AddTicks(465) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "ReleaseDate",
                value: new DateTime(2022, 2, 26, 10, 57, 36, 653, DateTimeKind.Local).AddTicks(412));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "ReleaseDate",
                value: new DateTime(2022, 2, 26, 10, 57, 36, 653, DateTimeKind.Local).AddTicks(440));
        }
    }
}
