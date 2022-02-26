using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GBCSportingWeb.Migrations
{
    public partial class ProductChanges7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ReleaseDate",
                table: "Products",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<string>(
                name: "ProductCode",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentId",
                keyValue: 1,
                columns: new[] { "DateClosed", "DateOpened" },
                values: new object[] { new DateTime(2022, 2, 24, 15, 0, 44, 150, DateTimeKind.Local).AddTicks(1639), new DateTime(2022, 2, 24, 15, 0, 44, 150, DateTimeKind.Local).AddTicks(1638) });

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentId",
                keyValue: 2,
                columns: new[] { "DateClosed", "DateOpened" },
                values: new object[] { new DateTime(2022, 2, 24, 15, 0, 44, 150, DateTimeKind.Local).AddTicks(1641), new DateTime(2022, 2, 24, 15, 0, 44, 150, DateTimeKind.Local).AddTicks(1640) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "ProductCode", "ProductName", "ReleaseDate", "YearlyPrice" },
                values: new object[] { "TPYR1090", "Tournament Master 1.0", new DateTime(2022, 2, 24, 15, 0, 44, 150, DateTimeKind.Local).AddTicks(1603), 9.9900000000000002 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "ProductCode", "ProductName", "ReleaseDate", "YearlyPrice" },
                values: new object[] { "WURE0115", "League Scheduler 1.0", new DateTime(2022, 2, 24, 15, 0, 44, 150, DateTimeKind.Local).AddTicks(1613), 50.979999999999997 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductCode",
                table: "Products");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReleaseDate",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

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
                columns: new[] { "ProductName", "ReleaseDate", "YearlyPrice" },
                values: new object[] { "Thom", new DateTime(2022, 2, 22, 17, 22, 32, 63, DateTimeKind.Local).AddTicks(81), 99.989999999999995 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "ProductName", "ReleaseDate", "YearlyPrice" },
                values: new object[] { "Edward", new DateTime(2022, 2, 22, 17, 22, 32, 63, DateTimeKind.Local).AddTicks(103), 115.98 });
        }
    }
}
