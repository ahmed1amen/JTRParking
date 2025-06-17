using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JTRParking.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Settings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Key = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Settings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<decimal>(type: "decimal(20,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Shifts",
                columns: table => new
                {
                    Id = table.Column<decimal>(type: "decimal(20,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    EndTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<decimal>(type: "decimal(20,0)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shifts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Shifts_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Parkings",
                columns: table => new
                {
                    Id = table.Column<decimal>(type: "decimal(20,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehicleType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DriverName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DriverMobile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Barcode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OutTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<decimal>(type: "decimal(20,0)", nullable: false),
                    ModifiedBy = table.Column<decimal>(type: "decimal(20,0)", nullable: true),
                    ShiftId = table.Column<decimal>(type: "decimal(20,0)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parkings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Parkings_Shifts_ShiftId",
                        column: x => x.ShiftId,
                        principalTable: "Shifts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Parkings_Users_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Parkings_Users_ModifiedBy",
                        column: x => x.ModifiedBy,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Settings",
                columns: new[] { "Id", "Key", "Value" },
                values: new object[,]
                {
                    { 1, "first_hour_rate", "50" },
                    { 2, "hourly_rate", "20" },
                    { 3, "currency_symbol", "MAD" },
                    { 4, "parking_ticket_header_title", "JTR Parking" },
                    { 5, "parking_ticket_header_sub_title", "JTR Solutions" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Name", "Password", "Role", "Username" },
                values: new object[,]
                {
                    { 1m, "Admin", "admin", 0, "admin" },
                    { 2m, "Employee IN", "employeein", 1, "employeein" },
                    { 3m, "Employee OUT", "employeeout", 2, "employeeout" }
                });

            migrationBuilder.InsertData(
                table: "Shifts",
                columns: new[] { "Id", "CreatedAt", "EndTime", "Name", "StartTime", "Status", "UserId" },
                values: new object[,]
                {
                    { 1m, new DateTime(2025, 6, 16, 15, 45, 16, 648, DateTimeKind.Local).AddTicks(4195), new TimeSpan(0, 16, 0, 0, 0), "Morning Shift", new TimeSpan(0, 8, 0, 0, 0), 1, 2m },
                    { 2m, new DateTime(2025, 6, 16, 15, 45, 16, 648, DateTimeKind.Local).AddTicks(4235), new TimeSpan(0, 23, 59, 0, 0), "Evening Shift", new TimeSpan(0, 16, 0, 0, 0), 0, 3m }
                });

            migrationBuilder.InsertData(
                table: "Parkings",
                columns: new[] { "Id", "Amount", "Barcode", "CreatedAt", "CreatedBy", "DriverMobile", "DriverName", "InTime", "ModifiedBy", "OutTime", "ShiftId", "Status", "VehicleType" },
                values: new object[,]
                {
                    { 1m, 100m, "202506161545161", new DateTime(2025, 6, 16, 15, 45, 16, 648, DateTimeKind.Local).AddTicks(5787), 1m, "+15485949548", "Hassan", new DateTime(2025, 6, 16, 15, 45, 16, 648, DateTimeKind.Local).AddTicks(5783), null, null, 1m, 0, "Car" },
                    { 2m, 200m, "202506162045161", new DateTime(2025, 6, 16, 15, 45, 16, 648, DateTimeKind.Local).AddTicks(5797), 1m, "+164598756", "Hassan", new DateTime(2025, 6, 16, 20, 45, 16, 648, DateTimeKind.Local).AddTicks(5795), null, null, 2m, 0, "Motor" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Parkings_CreatedBy",
                table: "Parkings",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Parkings_ModifiedBy",
                table: "Parkings",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Parkings_ShiftId",
                table: "Parkings",
                column: "ShiftId");

            migrationBuilder.CreateIndex(
                name: "IX_Shifts_UserId",
                table: "Shifts",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Parkings");

            migrationBuilder.DropTable(
                name: "Settings");

            migrationBuilder.DropTable(
                name: "Shifts");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
