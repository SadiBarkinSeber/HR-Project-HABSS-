using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HR_PROJECT.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class initExpenseValidation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Type",
                table: "Expenses",
                newName: "ExpenseType");

            migrationBuilder.AddColumn<decimal>(
                name: "AmountValue",
                table: "Expenses",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "AmountValue",
                table: "Advances",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.UpdateData(
                table: "Advances",
                keyColumn: "Id",
                keyValue: 1,
                column: "AmountValue",
                value: null);

            migrationBuilder.UpdateData(
                table: "Advances",
                keyColumn: "Id",
                keyValue: 2,
                column: "AmountValue",
                value: null);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "df5a9b38-18e8-48b7-97bf-ad4a9b4afe0e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "680b5fd1-50a0-4ad3-a566-dd2397db2284", "AQAAAAIAAYagAAAAELbNyIFTR+/8HKlJZjqzUDQwCY6ukgSFjikpcc8oo+NzsKljTbJSRe4iGYhYFgmN1w==" });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AmountValue", "ExpenseType" },
                values: new object[] { null, "İş Seyahatleri" });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AmountValue", "ExpenseType" },
                values: new object[] { null, "Personel Harcamaları" });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AmountValue",
                table: "Expenses");

            migrationBuilder.RenameColumn(
                name: "ExpenseType",
                table: "Expenses",
                newName: "Type");

            migrationBuilder.AlterColumn<decimal>(
                name: "AmountValue",
                table: "Advances",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Advances",
                keyColumn: "Id",
                keyValue: 1,
                column: "AmountValue",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "Advances",
                keyColumn: "Id",
                keyValue: 2,
                column: "AmountValue",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "df5a9b38-18e8-48b7-97bf-ad4a9b4afe0e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e5d49df9-8cf5-4c55-bccb-fdaba1e29710", "AQAAAAIAAYagAAAAEFfie+O59zM9F90XfknCahEuNCZzt5koykWUKSj3IW8smJF6zfCmxbQE4Ncu3DKEzA==" });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1,
                column: "Type",
                value: "İş Seyahati");

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 2,
                column: "Type",
                value: "Yemek Gideri");

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "RequestDate",
                value: new DateTime(2024, 3, 22, 13, 14, 6, 971, DateTimeKind.Local).AddTicks(1174));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "RequestDate",
                value: new DateTime(2024, 3, 22, 13, 14, 6, 971, DateTimeKind.Local).AddTicks(1192));
        }
    }
}
