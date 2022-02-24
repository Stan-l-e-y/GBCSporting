using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GBCSportingWeb.Migrations
{
    public partial class CustomerModelChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "Address", "City", "CountryId", "Email", "FirstName", "LastName", "Phone", "PostalCode", "State" },
                values: new object[] { 2, "4th Avenue", "NYC", 187, null, "Stanley", "Tsonev", null, "J1C 8Y1", "New York" });

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentId",
                keyValue: 1,
                columns: new[] { "DateClosed", "DateOpened" },
                values: new object[] { new DateTime(2022, 2, 23, 23, 26, 55, 2, DateTimeKind.Local).AddTicks(6127), new DateTime(2022, 2, 23, 23, 26, 55, 2, DateTimeKind.Local).AddTicks(6123) });

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentId",
                keyValue: 2,
                columns: new[] { "DateClosed", "DateOpened" },
                values: new object[] { new DateTime(2022, 2, 23, 23, 26, 55, 2, DateTimeKind.Local).AddTicks(6132), new DateTime(2022, 2, 23, 23, 26, 55, 2, DateTimeKind.Local).AddTicks(6130) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "ReleaseDate",
                value: new DateTime(2022, 2, 23, 23, 26, 55, 2, DateTimeKind.Local).AddTicks(6048));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "ReleaseDate",
                value: new DateTime(2022, 2, 23, 23, 26, 55, 2, DateTimeKind.Local).AddTicks(6083));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 2);

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
                column: "ReleaseDate",
                value: new DateTime(2022, 2, 22, 17, 22, 32, 63, DateTimeKind.Local).AddTicks(81));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "ReleaseDate",
                value: new DateTime(2022, 2, 22, 17, 22, 32, 63, DateTimeKind.Local).AddTicks(103));
        }
    }
}
