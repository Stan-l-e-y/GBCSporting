using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GBCSportingWeb.Migrations
{
    public partial class ProductChange4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentId",
                keyValue: 1,
                columns: new[] { "DateClosed", "DateOpened" },
                values: new object[] { new DateTime(2022, 2, 21, 15, 11, 9, 949, DateTimeKind.Local).AddTicks(5991), new DateTime(2022, 2, 21, 15, 11, 9, 949, DateTimeKind.Local).AddTicks(5990) });

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentId",
                keyValue: 2,
                columns: new[] { "DateClosed", "DateOpened" },
                values: new object[] { new DateTime(2022, 2, 21, 15, 11, 9, 949, DateTimeKind.Local).AddTicks(5993), new DateTime(2022, 2, 21, 15, 11, 9, 949, DateTimeKind.Local).AddTicks(5992) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "ReleaseDate",
                value: new DateTime(2022, 2, 21, 15, 11, 9, 949, DateTimeKind.Local).AddTicks(5934));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "ReleaseDate",
                value: new DateTime(2022, 2, 21, 15, 11, 9, 949, DateTimeKind.Local).AddTicks(5949));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
