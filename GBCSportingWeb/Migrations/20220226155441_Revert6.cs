using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GBCSportingWeb.Migrations
{
    public partial class Revert6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOpened",
                table: "Incidents",
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
                values: new object[] { new DateTime(2022, 2, 26, 10, 54, 40, 975, DateTimeKind.Local).AddTicks(1877), new DateTime(2022, 2, 26, 10, 54, 40, 975, DateTimeKind.Local).AddTicks(1875) });

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentId",
                keyValue: 2,
                columns: new[] { "DateClosed", "DateOpened" },
                values: new object[] { new DateTime(2022, 2, 26, 10, 54, 40, 975, DateTimeKind.Local).AddTicks(1880), new DateTime(2022, 2, 26, 10, 54, 40, 975, DateTimeKind.Local).AddTicks(1878) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "ReleaseDate",
                value: new DateTime(2022, 2, 26, 10, 54, 40, 975, DateTimeKind.Local).AddTicks(1818));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "ReleaseDate",
                value: new DateTime(2022, 2, 26, 10, 54, 40, 975, DateTimeKind.Local).AddTicks(1850));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOpened",
                table: "Incidents",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentId",
                keyValue: 1,
                columns: new[] { "DateClosed", "DateOpened" },
                values: new object[] { new DateTime(2022, 2, 26, 10, 45, 45, 339, DateTimeKind.Local).AddTicks(9539), new DateTime(2022, 2, 26, 10, 45, 45, 339, DateTimeKind.Local).AddTicks(9537) });

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentId",
                keyValue: 2,
                columns: new[] { "DateClosed", "DateOpened" },
                values: new object[] { new DateTime(2022, 2, 26, 10, 45, 45, 339, DateTimeKind.Local).AddTicks(9543), new DateTime(2022, 2, 26, 10, 45, 45, 339, DateTimeKind.Local).AddTicks(9542) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "ReleaseDate",
                value: new DateTime(2022, 2, 26, 10, 45, 45, 339, DateTimeKind.Local).AddTicks(9483));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "ReleaseDate",
                value: new DateTime(2022, 2, 26, 10, 45, 45, 339, DateTimeKind.Local).AddTicks(9517));
        }
    }
}
