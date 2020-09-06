using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Insurance.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "Policies",
                columns: table => new
                {
                    PolicyId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<long>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    TypeOfCovering = table.Column<string>(nullable: true),
                    CoveragePercentage = table.Column<int>(nullable: false),
                    StartOfValidity = table.Column<DateTime>(nullable: false),
                    Period = table.Column<int>(nullable: false),
                    Price = table.Column<float>(nullable: false),
                    TypeOfRisk = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Policies", x => x.PolicyId);
                    table.ForeignKey(
                        name: "FK_Policies_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "Name" },
                values: new object[] { 1L, "Bob" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "Name" },
                values: new object[] { 2L, "Jhon" });

            migrationBuilder.InsertData(
                table: "Policies",
                columns: new[] { "PolicyId", "CoveragePercentage", "CustomerId", "Name", "Period", "Price", "StartOfValidity", "TypeOfCovering", "TypeOfRisk" },
                values: new object[] { 1L, 100, 1L, "Poliza Contra Incendio", 12, 1000000f, new DateTime(2020, 9, 7, 20, 46, 37, 334, DateTimeKind.Local).AddTicks(742), "Incendio", "Bajo" });

            migrationBuilder.InsertData(
                table: "Policies",
                columns: new[] { "PolicyId", "CoveragePercentage", "CustomerId", "Name", "Period", "Price", "StartOfValidity", "TypeOfCovering", "TypeOfRisk" },
                values: new object[] { 2L, 100, 2L, "Poliza Contra Robo", 12, 1000000f, new DateTime(2020, 9, 10, 20, 46, 37, 335, DateTimeKind.Local).AddTicks(2313), "Robo", "Medio-Alto" });

            migrationBuilder.CreateIndex(
                name: "IX_Policies_CustomerId",
                table: "Policies",
                column: "CustomerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Policies");

            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
