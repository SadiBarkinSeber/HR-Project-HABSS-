using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HR_PROJECT.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class init123 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MersisNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TaxNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TaxDepartment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LogoImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeeCount = table.Column<int>(type: "int", nullable: false),
                    FoundingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DealStartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DealEndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29eee336-e6a2-40f2-9305-159eed59ed75",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7e50c294-ae31-4d7c-9607-22a05c3a8cac", "AQAAAAIAAYagAAAAEPUMRb7ANTBVpDoJ7vx7FsCSVd/swEl5VqJymkTJrjih6aOYhG97eopVBLlVnLuW/g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "df5a9b38-18e8-48b7-97bf-ad4a9b4afe0e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2de6000b-7776-4844-815a-bf7020fc5dfa", "AQAAAAIAAYagAAAAENrLlbwTtSTWQU3WYh7SU1S+m/emYbUpgZIN1HgknjxgwWDkyy8XlWSVB+VtTzHmqg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ff05bc01-696c-4968-8e4f-cc707cceafad",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c0d75118-a7ce-4134-8ffd-e7fac9390ab6", "AQAAAAIAAYagAAAAEAK4f2cP+g5FvIdnaXHwhbMZ8FB8h1G0b6v+w6af0RdaxR6t/tADHKIzfwMfdmYRmQ==" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29eee336-e6a2-40f2-9305-159eed59ed75",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "47d2f674-2206-41ee-b146-7d07fad3a408", "AQAAAAIAAYagAAAAECX/wtJxbjzqECd3DYI8JCWN3d1qtjJmeaahpBEbN56iz9Kz+k9/+qstlMfcBR27Jw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "df5a9b38-18e8-48b7-97bf-ad4a9b4afe0e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "11d51019-b97e-472b-a32f-2de72fd72da4", "AQAAAAIAAYagAAAAEGYxVkypHpHVe/a8yhSJYG9pkhUBtMk7CL/DPfRAWiNdBmScvAhidmQ68gBPN4q26Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ff05bc01-696c-4968-8e4f-cc707cceafad",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b0f3eb0d-774c-4bbf-992b-3308756d43c1", "AQAAAAIAAYagAAAAENSnOdPOmnaTTz3xzX3PVEZADmWk3dclLtsDk7vQNL5rTf1r5JRoy7ZicdI1llZR4g==" });
        }
    }
}
