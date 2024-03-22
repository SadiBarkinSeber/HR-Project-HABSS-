using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HR_PROJECT.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class initExpenseValidation2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "df5a9b38-18e8-48b7-97bf-ad4a9b4afe0e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f03980b4-50ef-430c-94d8-415d40cdfdd4", "AQAAAAIAAYagAAAAEPvQD/3oeZUyfsBjIrv6YFulZEQaEZS5PfwXtJiYfCWV29pDd46PW5S6tmRhMqcYVg==" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "RequestDate",
                value: new DateTime(2024, 3, 22, 15, 43, 53, 860, DateTimeKind.Local).AddTicks(7671));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "RequestDate",
                value: new DateTime(2024, 3, 22, 15, 43, 53, 860, DateTimeKind.Local).AddTicks(7787));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "df5a9b38-18e8-48b7-97bf-ad4a9b4afe0e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "680b5fd1-50a0-4ad3-a566-dd2397db2284", "AQAAAAIAAYagAAAAELbNyIFTR+/8HKlJZjqzUDQwCY6ukgSFjikpcc8oo+NzsKljTbJSRe4iGYhYFgmN1w==" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "RequestDate",
                value: new DateTime(2024, 3, 22, 15, 43, 2, 82, DateTimeKind.Local).AddTicks(8851));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "RequestDate",
                value: new DateTime(2024, 3, 22, 15, 43, 2, 82, DateTimeKind.Local).AddTicks(8868));
        }
    }
}
