using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HR_PROJECT.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class initAdvance : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Advances",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdvanceType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ApprovalStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RequestDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Response = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Currency = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Permission = table.Column<bool>(type: "bit", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Advances", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Advances_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Advances",
                columns: new[] { "Id", "AdvanceType", "Amount", "ApprovalStatus", "Currency", "Description", "EmployeeId", "Permission", "RequestDate", "Response" },
                values: new object[,]
                {
                    { 1, "Bireysel", 5631.45m, "Pending", "TL", "Araba alıcam", 1, false, new DateTime(2024, 3, 16, 15, 10, 8, 138, DateTimeKind.Local).AddTicks(8537), "Please provide necessary documents." },
                    { 2, "Kurumsal", 6592.45m, "Approved", "TL", "Motor alıcam", 1, true, new DateTime(2024, 3, 16, 15, 10, 8, 138, DateTimeKind.Local).AddTicks(8543), "Request have been approved." }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "df5a9b38-18e8-48b7-97bf-ad4a9b4afe0e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "067da5aa-b0d7-45c8-968e-4c31b82deb3f", "AQAAAAIAAYagAAAAELMl8Yke1PQtr/Dx11NBLAryVoACMd0ICHHgeHQsqaJfP+lS/NsRBFwD4TCAM3RFDA==" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "RequestDate",
                value: new DateTime(2024, 3, 16, 15, 10, 8, 138, DateTimeKind.Local).AddTicks(7516));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "RequestDate",
                value: new DateTime(2024, 3, 16, 15, 10, 8, 138, DateTimeKind.Local).AddTicks(7535));

            migrationBuilder.CreateIndex(
                name: "IX_Advances_EmployeeId",
                table: "Advances",
                column: "EmployeeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Advances");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "df5a9b38-18e8-48b7-97bf-ad4a9b4afe0e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7caeb8bb-8ca9-41f9-95e3-2000ec122253", "AQAAAAIAAYagAAAAEOsuNCiu3ehVwJhgudsJKCoG2boSfHeZMdFm8FHM3u5eQVggMgiWNVumH9OYygaJ3g==" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "RequestDate",
                value: new DateTime(2024, 3, 15, 17, 56, 0, 421, DateTimeKind.Local).AddTicks(8544));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "RequestDate",
                value: new DateTime(2024, 3, 15, 17, 56, 0, 421, DateTimeKind.Local).AddTicks(8561));
        }
    }
}
