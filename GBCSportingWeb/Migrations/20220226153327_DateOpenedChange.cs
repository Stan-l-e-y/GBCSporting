using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GBCSportingWeb.Migrations
{
    public partial class DateOpenedChange : Migration
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
                values: new object[] { new DateTime(2022, 2, 26, 9, 2, 59, 814, DateTimeKind.Local).AddTicks(9254), new DateTime(2022, 2, 26, 9, 2, 59, 814, DateTimeKind.Local).AddTicks(9252) });

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentId",
                keyValue: 2,
                columns: new[] { "DateClosed", "DateOpened" },
                values: new object[] { new DateTime(2022, 2, 26, 9, 2, 59, 814, DateTimeKind.Local).AddTicks(9257), new DateTime(2022, 2, 26, 9, 2, 59, 814, DateTimeKind.Local).AddTicks(9255) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "ReleaseDate",
                value: new DateTime(2022, 2, 26, 9, 2, 59, 814, DateTimeKind.Local).AddTicks(9201));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "ReleaseDate",
                value: new DateTime(2022, 2, 26, 9, 2, 59, 814, DateTimeKind.Local).AddTicks(9231));
        }
    }
}
