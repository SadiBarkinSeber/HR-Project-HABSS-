using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HR_PROJECT.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class initPermissions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Permissions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PermissionType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RequestDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NumberOfDays = table.Column<int>(type: "int", nullable: true),
                    FileName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApprovalStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permissions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Permissions_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "df5a9b38-18e8-48b7-97bf-ad4a9b4afe0e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7caeb8bb-8ca9-41f9-95e3-2000ec122253", "AQAAAAIAAYagAAAAEOsuNCiu3ehVwJhgudsJKCoG2boSfHeZMdFm8FHM3u5eQVggMgiWNVumH9OYygaJ3g==" });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "ApprovalStatus", "EmployeeId", "EndDate", "FileName", "NumberOfDays", "PermissionType", "RequestDate", "StartDate" },
                values: new object[,]
                {
                    { 1, "Onay bekleniyor", 1, new DateTime(2024, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10, "Baba izni", new DateTime(2024, 3, 15, 17, 56, 0, 421, DateTimeKind.Local).AddTicks(8544), new DateTime(2024, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "Onay bekleniyor", 1, new DateTime(2024, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 30, "Annelik izni", new DateTime(2024, 3, 15, 17, 56, 0, 421, DateTimeKind.Local).AddTicks(8561), new DateTime(2024, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Permissions_EmployeeId",
                table: "Permissions",
                column: "EmployeeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Permissions");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "df5a9b38-18e8-48b7-97bf-ad4a9b4afe0e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "cade5859-f426-4870-875c-73667d0cabae", "AQAAAAIAAYagAAAAENrddw2yBVZ/Rjiw88SdQba+6dyAJeZMA8bQpU/rYAEpKQrgTmGXwZJsEYZOIqq5Kg==" });
        }
    }
}
