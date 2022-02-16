using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GBCSportingWeb.Migrations
{
    public partial class addDbSets : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Incidents_Customer_CustomerId",
                table: "Incidents");

            migrationBuilder.DropForeignKey(
                name: "FK_Incidents_Product_ProductId",
                table: "Incidents");

            migrationBuilder.DropForeignKey(
                name: "FK_Incidents_Technician_TechnicianId",
                table: "Incidents");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Technician",
                table: "Technician");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Product",
                table: "Product");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Customer",
                table: "Customer");

            migrationBuilder.RenameTable(
                name: "Technician",
                newName: "Technicianes");

            migrationBuilder.RenameTable(
                name: "Product",
                newName: "Products");

            migrationBuilder.RenameTable(
                name: "Customer",
                newName: "Customers");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Technicianes",
                table: "Technicianes",
                column: "TechnicianId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products",
                table: "Products",
                column: "ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customers",
                table: "Customers",
                column: "CustomerId");

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
                name: "FK_Incidents_Customers_CustomerId",
                table: "Incidents",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Incidents_Products_ProductId",
                table: "Incidents",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Incidents_Technicianes_TechnicianId",
                table: "Incidents",
                column: "TechnicianId",
                principalTable: "Technicianes",
                principalColumn: "TechnicianId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Incidents_Customers_CustomerId",
                table: "Incidents");

            migrationBuilder.DropForeignKey(
                name: "FK_Incidents_Products_ProductId",
                table: "Incidents");

            migrationBuilder.DropForeignKey(
                name: "FK_Incidents_Technicianes_TechnicianId",
                table: "Incidents");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Technicianes",
                table: "Technicianes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Products",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Customers",
                table: "Customers");

            migrationBuilder.RenameTable(
                name: "Technicianes",
                newName: "Technician");

            migrationBuilder.RenameTable(
                name: "Products",
                newName: "Product");

            migrationBuilder.RenameTable(
                name: "Customers",
                newName: "Customer");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Technician",
                table: "Technician",
                column: "TechnicianId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Product",
                table: "Product",
                column: "ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customer",
                table: "Customer",
                column: "CustomerId");

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentId",
                keyValue: 1,
                columns: new[] { "DateClosed", "DateOpened" },
                values: new object[] { new DateTime(2022, 2, 12, 16, 35, 25, 805, DateTimeKind.Local).AddTicks(2674), new DateTime(2022, 2, 12, 16, 35, 25, 805, DateTimeKind.Local).AddTicks(2644) });

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentId",
                keyValue: 2,
                columns: new[] { "DateClosed", "DateOpened" },
                values: new object[] { new DateTime(2022, 2, 12, 16, 35, 25, 805, DateTimeKind.Local).AddTicks(2678), new DateTime(2022, 2, 12, 16, 35, 25, 805, DateTimeKind.Local).AddTicks(2677) });

            migrationBuilder.AddForeignKey(
                name: "FK_Incidents_Customer_CustomerId",
                table: "Incidents",
                column: "CustomerId",
                principalTable: "Customer",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Incidents_Product_ProductId",
                table: "Incidents",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Incidents_Technician_TechnicianId",
                table: "Incidents",
                column: "TechnicianId",
                principalTable: "Technician",
                principalColumn: "TechnicianId");
        }
    }
}
