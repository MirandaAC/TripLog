using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TripLog.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Trips",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Destination = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Accomodation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Thingstodo1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Thingstodo2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Thingstodo3 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trips", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[] { "Id", "Accomodation", "Destination", "Email", "EndDate", "Phone", "StartDate", "Thingstodo1", "Thingstodo2", "Thingstodo3" },
                values: new object[,]
                {
                    { 1, "The Benson Hotel", "Portland", "staff@thebenson.com", new DateTime(2024, 3, 10, 15, 44, 0, 737, DateTimeKind.Local).AddTicks(2847), "503-555-1234", new DateTime(2024, 3, 10, 15, 44, 0, 737, DateTimeKind.Local).AddTicks(2794), "Get Voodoo donuts", "Walk in the rain", "Go to Powell's" },
                    { 2, "Holiday Inn Express", "Boise", null, new DateTime(2024, 3, 10, 15, 44, 0, 737, DateTimeKind.Local).AddTicks(2852), null, new DateTime(2024, 3, 10, 15, 44, 0, 737, DateTimeKind.Local).AddTicks(2850), "Visit Family", null, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Trips");
        }
    }
}
