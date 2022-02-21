using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GBCSportingWeb.Migrations
{
    public partial class ProductChanges3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentId",
                keyValue: 1,
                columns: new[] { "DateClosed", "DateOpened" },
                values: new object[] { new DateTime(2022, 2, 21, 14, 59, 21, 745, DateTimeKind.Local).AddTicks(7013), new DateTime(2022, 2, 21, 14, 59, 21, 745, DateTimeKind.Local).AddTicks(7011) });

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentId",
                keyValue: 2,
                columns: new[] { "DateClosed", "DateOpened" },
                values: new object[] { new DateTime(2022, 2, 21, 14, 59, 21, 745, DateTimeKind.Local).AddTicks(7014), new DateTime(2022, 2, 21, 14, 59, 21, 745, DateTimeKind.Local).AddTicks(7014) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "ReleaseDate",
                value: new DateTime(2022, 2, 21, 14, 59, 21, 745, DateTimeKind.Local).AddTicks(6972));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "ReleaseDate",
                value: new DateTime(2022, 2, 21, 14, 59, 21, 745, DateTimeKind.Local).AddTicks(6984));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentId",
                keyValue: 1,
                columns: new[] { "DateClosed", "DateOpened" },
                values: new object[] { new DateTime(2022, 2, 21, 14, 51, 51, 875, DateTimeKind.Local).AddTicks(8268), new DateTime(2022, 2, 21, 14, 51, 51, 875, DateTimeKind.Local).AddTicks(8266) });

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentId",
                keyValue: 2,
                columns: new[] { "DateClosed", "DateOpened" },
                values: new object[] { new DateTime(2022, 2, 21, 14, 51, 51, 875, DateTimeKind.Local).AddTicks(8269), new DateTime(2022, 2, 21, 14, 51, 51, 875, DateTimeKind.Local).AddTicks(8269) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "ReleaseDate",
                value: new DateTime(2022, 2, 21, 14, 51, 51, 875, DateTimeKind.Local).AddTicks(8218));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "ReleaseDate",
                value: new DateTime(2022, 2, 21, 14, 51, 51, 875, DateTimeKind.Local).AddTicks(8227));
        }
    }
}
