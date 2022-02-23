using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GBCSportingWeb.Migrations
{
    public partial class ProductChange6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentId",
                keyValue: 1,
                columns: new[] { "DateClosed", "DateOpened" },
                values: new object[] { new DateTime(2022, 2, 22, 17, 22, 32, 63, DateTimeKind.Local).AddTicks(125), new DateTime(2022, 2, 22, 17, 22, 32, 63, DateTimeKind.Local).AddTicks(123) });

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentId",
                keyValue: 2,
                columns: new[] { "DateClosed", "DateOpened" },
                values: new object[] { new DateTime(2022, 2, 22, 17, 22, 32, 63, DateTimeKind.Local).AddTicks(126), new DateTime(2022, 2, 22, 17, 22, 32, 63, DateTimeKind.Local).AddTicks(126) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "ReleaseDate",
                value: new DateTime(2022, 2, 22, 17, 22, 32, 63, DateTimeKind.Local).AddTicks(81));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "ReleaseDate",
                value: new DateTime(2022, 2, 22, 17, 22, 32, 63, DateTimeKind.Local).AddTicks(103));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentId",
                keyValue: 1,
                columns: new[] { "DateClosed", "DateOpened" },
                values: new object[] { new DateTime(2022, 2, 21, 15, 14, 28, 376, DateTimeKind.Local).AddTicks(5017), new DateTime(2022, 2, 21, 15, 14, 28, 376, DateTimeKind.Local).AddTicks(5015) });

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentId",
                keyValue: 2,
                columns: new[] { "DateClosed", "DateOpened" },
                values: new object[] { new DateTime(2022, 2, 21, 15, 14, 28, 376, DateTimeKind.Local).AddTicks(5018), new DateTime(2022, 2, 21, 15, 14, 28, 376, DateTimeKind.Local).AddTicks(5018) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "ReleaseDate",
                value: new DateTime(2022, 2, 21, 15, 14, 28, 376, DateTimeKind.Local).AddTicks(4985));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "ReleaseDate",
                value: new DateTime(2022, 2, 21, 15, 14, 28, 376, DateTimeKind.Local).AddTicks(4996));
        }
    }
}
