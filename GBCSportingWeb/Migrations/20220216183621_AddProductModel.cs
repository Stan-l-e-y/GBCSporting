using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GBCSportingWeb.Migrations
{
    public partial class AddProductModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ProductName",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "ReleaseDate",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<double>(
                name: "YearlyPrice",
                table: "Products",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentId",
                keyValue: 1,
                columns: new[] { "DateClosed", "DateOpened" },
                values: new object[] { new DateTime(2022, 2, 16, 15, 36, 20, 726, DateTimeKind.Local).AddTicks(2288), new DateTime(2022, 2, 16, 15, 36, 20, 726, DateTimeKind.Local).AddTicks(2286) });

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentId",
                keyValue: 2,
                columns: new[] { "DateClosed", "DateOpened" },
                values: new object[] { new DateTime(2022, 2, 16, 15, 36, 20, 726, DateTimeKind.Local).AddTicks(2290), new DateTime(2022, 2, 16, 15, 36, 20, 726, DateTimeKind.Local).AddTicks(2290) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "ProductName", "ReleaseDate", "YearlyPrice" },
                values: new object[] { "Thom", new DateTime(2022, 2, 16, 15, 36, 20, 726, DateTimeKind.Local).AddTicks(2250), 99.989999999999995 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "ProductName", "ReleaseDate", "YearlyPrice" },
                values: new object[] { "Edward", new DateTime(2022, 2, 16, 15, 36, 20, 726, DateTimeKind.Local).AddTicks(2264), 115.98 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductName",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ReleaseDate",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "YearlyPrice",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentId",
                keyValue: 1,
                columns: new[] { "DateClosed", "DateOpened" },
                values: new object[] { new DateTime(2022, 2, 15, 18, 21, 53, 489, DateTimeKind.Local).AddTicks(8086), new DateTime(2022, 2, 15, 18, 21, 53, 489, DateTimeKind.Local).AddTicks(8058) });

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentId",
                keyValue: 2,
                columns: new[] { "DateClosed", "DateOpened" },
                values: new object[] { new DateTime(2022, 2, 15, 18, 21, 53, 489, DateTimeKind.Local).AddTicks(8090), new DateTime(2022, 2, 15, 18, 21, 53, 489, DateTimeKind.Local).AddTicks(8089) });
        }
    }
}
