using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GBCSportingWeb.Migrations
{
    public partial class SeedUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 2,
                column: "Email",
                value: "Stanley.Tsonev@gmail.com");

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "Address", "City", "CountryId", "Email", "FirstName", "LastName", "Phone", "PostalCode", "State" },
                values: new object[] { 3, "7th Avenue", "Tehran", 80, "Farshad.Jalali@gmail.com", "Farshad", "Jalali", null, "k1C 9T1", "Tehran" });

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentId",
                keyValue: 1,
                columns: new[] { "DateClosed", "DateOpened" },
                values: new object[] { new DateTime(2022, 2, 23, 23, 34, 52, 918, DateTimeKind.Local).AddTicks(9212), new DateTime(2022, 2, 23, 23, 34, 52, 918, DateTimeKind.Local).AddTicks(9208) });

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentId",
                keyValue: 2,
                columns: new[] { "DateClosed", "DateOpened" },
                values: new object[] { new DateTime(2022, 2, 23, 23, 34, 52, 918, DateTimeKind.Local).AddTicks(9217), new DateTime(2022, 2, 23, 23, 34, 52, 918, DateTimeKind.Local).AddTicks(9215) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "ReleaseDate",
                value: new DateTime(2022, 2, 23, 23, 34, 52, 918, DateTimeKind.Local).AddTicks(9132));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "ReleaseDate",
                value: new DateTime(2022, 2, 23, 23, 34, 52, 918, DateTimeKind.Local).AddTicks(9164));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 2,
                column: "Email",
                value: null);

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
    }
}
