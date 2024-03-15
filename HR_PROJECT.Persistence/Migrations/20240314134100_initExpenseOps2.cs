using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HR_PROJECT.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class initExpenseOps2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Amount",
                table: "Expenses",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "df5a9b38-18e8-48b7-97bf-ad4a9b4afe0e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "55d2c23f-4329-45fc-8693-44ae4210c542", "AQAAAAIAAYagAAAAEDB4SVVq4OalHHRNWRbcEF+VE5123doSHs+G7Kz9Ncq1993rx7WtM8gGMRorqikg3A==" });

            migrationBuilder.InsertData(
                table: "Expenses",
                columns: new[] { "Id", "Amount", "ApprovalStatus", "Currency", "EmployeeId", "FileName", "Permission", "RequestDate", "Response", "Type" },
                values: new object[,]
                {
                    { 1, 5631.45m, "Pending", "TL", 1, null, false, new DateTime(2024, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Please provide necessary documents.", "İş Seyahati" },
                    { 2, 6592.45m, "Approved", "TL", 1, null, true, new DateTime(2024, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Request have been approved.", "Yemek Gideri" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.AlterColumn<decimal>(
                name: "Amount",
                table: "Expenses",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "df5a9b38-18e8-48b7-97bf-ad4a9b4afe0e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0f14dc3f-d112-4d80-a803-dc42981cfaf7", "AQAAAAIAAYagAAAAEIunggww560SHodDhfVDayKJIVLm6dj1b3apoVN+92tok2rPF0O31xY1MdvoP6XYLQ==" });
        }
    }
}
