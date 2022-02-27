using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GBCSportingWeb.Migrations
{
    public partial class Revert2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentId",
                keyValue: 1,
                columns: new[] { "DateClosed", "DateOpened" },
                values: new object[] { new DateTime(2022, 2, 26, 10, 43, 43, 391, DateTimeKind.Local).AddTicks(7257), new DateTime(2022, 2, 26, 10, 43, 43, 391, DateTimeKind.Local).AddTicks(7255) });

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentId",
                keyValue: 2,
                columns: new[] { "DateClosed", "DateOpened" },
                values: new object[] { new DateTime(2022, 2, 26, 10, 43, 43, 391, DateTimeKind.Local).AddTicks(7260), new DateTime(2022, 2, 26, 10, 43, 43, 391, DateTimeKind.Local).AddTicks(7258) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "ReleaseDate",
                value: new DateTime(2022, 2, 26, 10, 43, 43, 391, DateTimeKind.Local).AddTicks(7202));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "ReleaseDate",
                value: new DateTime(2022, 2, 26, 10, 43, 43, 391, DateTimeKind.Local).AddTicks(7233));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentId",
                keyValue: 1,
                columns: new[] { "DateClosed", "DateOpened" },
                values: new object[] { new DateTime(2022, 2, 26, 10, 33, 27, 528, DateTimeKind.Local).AddTicks(8879), new DateTime(2022, 2, 26, 10, 33, 27, 528, DateTimeKind.Local).AddTicks(8878) });

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentId",
                keyValue: 2,
                columns: new[] { "DateClosed", "DateOpened" },
                values: new object[] { new DateTime(2022, 2, 26, 10, 33, 27, 528, DateTimeKind.Local).AddTicks(8883), new DateTime(2022, 2, 26, 10, 33, 27, 528, DateTimeKind.Local).AddTicks(8882) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "ReleaseDate",
                value: new DateTime(2022, 2, 26, 10, 33, 27, 528, DateTimeKind.Local).AddTicks(8819));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "ReleaseDate",
                value: new DateTime(2022, 2, 26, 10, 33, 27, 528, DateTimeKind.Local).AddTicks(8853));
        }
    }
}
