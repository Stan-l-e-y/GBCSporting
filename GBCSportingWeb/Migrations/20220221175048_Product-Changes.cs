using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GBCSportingWeb.Migrations
{
    public partial class ProductChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentId",
                keyValue: 1,
                columns: new[] { "DateClosed", "DateOpened" },
                values: new object[] { new DateTime(2022, 2, 21, 14, 50, 48, 578, DateTimeKind.Local).AddTicks(9587), new DateTime(2022, 2, 21, 14, 50, 48, 578, DateTimeKind.Local).AddTicks(9586) });

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentId",
                keyValue: 2,
                columns: new[] { "DateClosed", "DateOpened" },
                values: new object[] { new DateTime(2022, 2, 21, 14, 50, 48, 578, DateTimeKind.Local).AddTicks(9589), new DateTime(2022, 2, 21, 14, 50, 48, 578, DateTimeKind.Local).AddTicks(9589) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "ReleaseDate",
                value: new DateTime(2022, 2, 21, 14, 50, 48, 578, DateTimeKind.Local).AddTicks(9550));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "ReleaseDate",
                value: new DateTime(2022, 2, 21, 14, 50, 48, 578, DateTimeKind.Local).AddTicks(9561));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentId",
                keyValue: 1,
                columns: new[] { "DateClosed", "DateOpened" },
                values: new object[] { new DateTime(2022, 2, 17, 0, 16, 41, 307, DateTimeKind.Local).AddTicks(3703), new DateTime(2022, 2, 17, 0, 16, 41, 307, DateTimeKind.Local).AddTicks(3652) });

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentId",
                keyValue: 2,
                columns: new[] { "DateClosed", "DateOpened" },
                values: new object[] { new DateTime(2022, 2, 17, 0, 16, 41, 307, DateTimeKind.Local).AddTicks(3714), new DateTime(2022, 2, 17, 0, 16, 41, 307, DateTimeKind.Local).AddTicks(3711) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "ReleaseDate",
                value: new DateTime(2022, 2, 16, 15, 36, 20, 726, DateTimeKind.Local).AddTicks(2250));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "ReleaseDate",
                value: new DateTime(2022, 2, 16, 15, 36, 20, 726, DateTimeKind.Local).AddTicks(2264));
        }
    }
}
