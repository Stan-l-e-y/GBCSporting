using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GBCSportingWeb.Migrations
{
    public partial class ManyToManyAddedRegistrations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Registrations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Registrations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Registrations_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Registrations_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentId",
                keyValue: 1,
                columns: new[] { "DateClosed", "DateOpened" },
                values: new object[] { new DateTime(2022, 3, 24, 16, 36, 11, 944, DateTimeKind.Local).AddTicks(6424), new DateTime(2022, 3, 24, 16, 36, 11, 944, DateTimeKind.Local).AddTicks(6422) });

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentId",
                keyValue: 2,
                columns: new[] { "DateClosed", "DateOpened" },
                values: new object[] { new DateTime(2022, 3, 24, 16, 36, 11, 944, DateTimeKind.Local).AddTicks(6428), new DateTime(2022, 3, 24, 16, 36, 11, 944, DateTimeKind.Local).AddTicks(6427) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "ReleaseDate",
                value: new DateTime(2022, 3, 24, 16, 36, 11, 944, DateTimeKind.Local).AddTicks(6376));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "ReleaseDate",
                value: new DateTime(2022, 3, 24, 16, 36, 11, 944, DateTimeKind.Local).AddTicks(6379));

            migrationBuilder.CreateIndex(
                name: "IX_Registrations_CustomerId",
                table: "Registrations",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Registrations_ProductId",
                table: "Registrations",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Registrations");

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentId",
                keyValue: 1,
                columns: new[] { "DateClosed", "DateOpened" },
                values: new object[] { new DateTime(2022, 3, 21, 20, 51, 58, 746, DateTimeKind.Local).AddTicks(9128), new DateTime(2022, 3, 21, 20, 51, 58, 746, DateTimeKind.Local).AddTicks(9127) });

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentId",
                keyValue: 2,
                columns: new[] { "DateClosed", "DateOpened" },
                values: new object[] { new DateTime(2022, 3, 21, 20, 51, 58, 746, DateTimeKind.Local).AddTicks(9132), new DateTime(2022, 3, 21, 20, 51, 58, 746, DateTimeKind.Local).AddTicks(9130) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "ReleaseDate",
                value: new DateTime(2022, 3, 21, 20, 51, 58, 746, DateTimeKind.Local).AddTicks(9100));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "ReleaseDate",
                value: new DateTime(2022, 3, 21, 20, 51, 58, 746, DateTimeKind.Local).AddTicks(9103));
        }
    }
}
