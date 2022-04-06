using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GBCSportingWeb.Migrations
{
    public partial class MoreValidationToCustomer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentId",
                keyValue: 1,
                columns: new[] { "DateClosed", "DateOpened" },
                values: new object[] { new DateTime(2022, 4, 3, 15, 43, 39, 96, DateTimeKind.Local).AddTicks(8582), new DateTime(2022, 4, 3, 15, 43, 39, 96, DateTimeKind.Local).AddTicks(8581) });

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentId",
                keyValue: 2,
                columns: new[] { "DateClosed", "DateOpened" },
                values: new object[] { new DateTime(2022, 4, 3, 15, 43, 39, 96, DateTimeKind.Local).AddTicks(8585), new DateTime(2022, 4, 3, 15, 43, 39, 96, DateTimeKind.Local).AddTicks(8584) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "ReleaseDate",
                value: new DateTime(2022, 4, 3, 15, 43, 39, 96, DateTimeKind.Local).AddTicks(8556));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "ReleaseDate",
                value: new DateTime(2022, 4, 3, 15, 43, 39, 96, DateTimeKind.Local).AddTicks(8559));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentId",
                keyValue: 1,
                columns: new[] { "DateClosed", "DateOpened" },
                values: new object[] { new DateTime(2022, 3, 24, 18, 10, 53, 310, DateTimeKind.Local).AddTicks(2462), new DateTime(2022, 3, 24, 18, 10, 53, 310, DateTimeKind.Local).AddTicks(2461) });

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentId",
                keyValue: 2,
                columns: new[] { "DateClosed", "DateOpened" },
                values: new object[] { new DateTime(2022, 3, 24, 18, 10, 53, 310, DateTimeKind.Local).AddTicks(2466), new DateTime(2022, 3, 24, 18, 10, 53, 310, DateTimeKind.Local).AddTicks(2465) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "ReleaseDate",
                value: new DateTime(2022, 3, 24, 18, 10, 53, 310, DateTimeKind.Local).AddTicks(2433));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "ReleaseDate",
                value: new DateTime(2022, 3, 24, 18, 10, 53, 310, DateTimeKind.Local).AddTicks(2437));
        }
    }
}
