using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HR_PROJECT.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class initEmployeeSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Wage",
                table: "Employees",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "BirthPlace", "Company", "DateOfBirth", "Department", "EndDate", "FirstName", "FirstSurname", "ImagePath", "IsActive", "Mail", "PhoneNumber", "Position", "SecondName", "SecondSurname", "StartDate", "Tc", "Wage" },
                values: new object[,]
                {
                    { 1, "Antalya/Türkiye", "Amazon Inc.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1968), "Technology and Strategy", null, "John", "Doe", "/Images/john_doe.jpg", true, "john.doe@bilgeadam.com", "5417896325", "Director", null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1989), "19586478952", 95489m },
                    { 2, "London/Great Britain", "Koç Group", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1972), "IT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2000), "Jane", "Doe", "/Images/jane_doe.jpg", false, "jane.doe@bilgeadam.com", "5085234563", "Lead Architect", "Margaret", "Thatcher", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1985), "78952612374", 63951m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.AlterColumn<decimal>(
                name: "Wage",
                table: "Employees",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");
        }
    }
}
