using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GBCSportingWeb.Migrations
{
    public partial class AddSeedDataForTechnician : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Incidents_Technicianes_TechnicianId",
                table: "Incidents");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Technicianes",
                table: "Technicianes");

            migrationBuilder.RenameTable(
                name: "Technicianes",
                newName: "Technicians");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Technicians",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Technicians",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "Technicians",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Technicians",
                table: "Technicians",
                column: "TechnicianId");

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

            migrationBuilder.UpdateData(
                table: "Technicians",
                keyColumn: "TechnicianId",
                keyValue: 1,
                columns: new[] { "Email", "Name", "Phone" },
                values: new object[] { "Sarah.Sami@georgebrown.ca", "Sarah Sami", "4168290752" });

            migrationBuilder.UpdateData(
                table: "Technicians",
                keyColumn: "TechnicianId",
                keyValue: 2,
                columns: new[] { "Email", "Name", "Phone" },
                values: new object[] { "Tanja.Jamie@georgebrown.ca", "Tanja Jamie", "4167620781" });

            migrationBuilder.AddForeignKey(
                name: "FK_Incidents_Technicians_TechnicianId",
                table: "Incidents",
                column: "TechnicianId",
                principalTable: "Technicians",
                principalColumn: "TechnicianId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Incidents_Technicians_TechnicianId",
                table: "Incidents");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Technicians",
                table: "Technicians");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Technicians");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Technicians");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "Technicians");

            migrationBuilder.RenameTable(
                name: "Technicians",
                newName: "Technicianes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Technicianes",
                table: "Technicianes",
                column: "TechnicianId");

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentId",
                keyValue: 1,
                columns: new[] { "DateClosed", "DateOpened" },
                values: new object[] { new DateTime(2022, 2, 14, 18, 46, 56, 92, DateTimeKind.Local).AddTicks(1797), new DateTime(2022, 2, 14, 18, 46, 56, 92, DateTimeKind.Local).AddTicks(1768) });

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentId",
                keyValue: 2,
                columns: new[] { "DateClosed", "DateOpened" },
                values: new object[] { new DateTime(2022, 2, 14, 18, 46, 56, 92, DateTimeKind.Local).AddTicks(1801), new DateTime(2022, 2, 14, 18, 46, 56, 92, DateTimeKind.Local).AddTicks(1799) });

            migrationBuilder.AddForeignKey(
                name: "FK_Incidents_Technicianes_TechnicianId",
                table: "Incidents",
                column: "TechnicianId",
                principalTable: "Technicianes",
                principalColumn: "TechnicianId");
        }
    }
}
