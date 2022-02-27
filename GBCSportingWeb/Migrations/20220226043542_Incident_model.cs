using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GBCSportingWeb.Migrations
{
    public partial class Incident_model : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Incidents_Technicians_TechnicianId",
                table: "Incidents");

            migrationBuilder.AlterColumn<int>(
                name: "TechnicianId",
                table: "Incidents",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentId",
                keyValue: 1,
                columns: new[] { "DateClosed", "DateOpened" },
                values: new object[] { new DateTime(2022, 2, 25, 23, 35, 42, 575, DateTimeKind.Local).AddTicks(6287), new DateTime(2022, 2, 25, 23, 35, 42, 575, DateTimeKind.Local).AddTicks(6286) });

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentId",
                keyValue: 2,
                columns: new[] { "DateClosed", "DateOpened" },
                values: new object[] { new DateTime(2022, 2, 25, 23, 35, 42, 575, DateTimeKind.Local).AddTicks(6291), new DateTime(2022, 2, 25, 23, 35, 42, 575, DateTimeKind.Local).AddTicks(6289) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "ReleaseDate",
                value: new DateTime(2022, 2, 25, 23, 35, 42, 575, DateTimeKind.Local).AddTicks(6238));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "ReleaseDate",
                value: new DateTime(2022, 2, 25, 23, 35, 42, 575, DateTimeKind.Local).AddTicks(6265));

            migrationBuilder.AddForeignKey(
                name: "FK_Incidents_Technicians_TechnicianId",
                table: "Incidents",
                column: "TechnicianId",
                principalTable: "Technicians",
                principalColumn: "TechnicianId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Incidents_Technicians_TechnicianId",
                table: "Incidents");

            migrationBuilder.AlterColumn<int>(
                name: "TechnicianId",
                table: "Incidents",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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
                column: "ReleaseDate",
                value: new DateTime(2022, 2, 24, 15, 0, 44, 150, DateTimeKind.Local).AddTicks(1603));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "ReleaseDate",
                value: new DateTime(2022, 2, 24, 15, 0, 44, 150, DateTimeKind.Local).AddTicks(1613));

            migrationBuilder.AddForeignKey(
                name: "FK_Incidents_Technicians_TechnicianId",
                table: "Incidents",
                column: "TechnicianId",
                principalTable: "Technicians",
                principalColumn: "TechnicianId");
        }
    }
}
