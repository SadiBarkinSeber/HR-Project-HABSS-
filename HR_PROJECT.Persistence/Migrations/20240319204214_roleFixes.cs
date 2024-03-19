using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HR_PROJECT.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class roleFixes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "f6040633-db1b-4a48-be54-9f214e77ac9d", "29eee336-e6a2-40f2-9305-159eed59ed75" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29eee336-e6a2-40f2-9305-159eed59ed75",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "74ce04e7-684c-4d0f-84c9-7161b8ae5933", "AQAAAAIAAYagAAAAEBRiX3jdQskehDysKZd0V3OUeMSjmJGU5otLQqq1VR9QyIw3N7Emqlk7gw5AupXsxg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "df5a9b38-18e8-48b7-97bf-ad4a9b4afe0e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "fad0de63-5b32-46e1-a81b-5db4d905a161", "AQAAAAIAAYagAAAAEEtFkZZUY6iSf8zdgKugioZaHzWUWe2aTXvYzyKXJQSomyTJpvg1eYhZt6DITwFBbQ==" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "RequestDate",
                value: new DateTime(2024, 3, 19, 23, 42, 13, 914, DateTimeKind.Local).AddTicks(2852));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "RequestDate",
                value: new DateTime(2024, 3, 19, 23, 42, 13, 914, DateTimeKind.Local).AddTicks(2870));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f6040633-db1b-4a48-be54-9f214e77ac9d", "29eee336-e6a2-40f2-9305-159eed59ed75" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29eee336-e6a2-40f2-9305-159eed59ed75",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "65bd134c-4d37-4383-b07c-ecd886434e89", "AQAAAAIAAYagAAAAEANzMH+5A7zCEUMnqn8/K/0Xdf+KvGuXQqKKO2hAKRvsHPp3uZYMWLBuFALkaOA4IA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "df5a9b38-18e8-48b7-97bf-ad4a9b4afe0e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ebf9c2ca-32f4-4d71-9bd1-d34c44929997", "AQAAAAIAAYagAAAAEOdrHI4oVcRUrbPii+aG5jjDrTeUcV9uAYvDGfOIBQEfVuRau2cuBTyf/g7iJPBsDA==" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "RequestDate",
                value: new DateTime(2024, 3, 19, 23, 38, 17, 62, DateTimeKind.Local).AddTicks(7743));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "RequestDate",
                value: new DateTime(2024, 3, 19, 23, 38, 17, 62, DateTimeKind.Local).AddTicks(7759));
        }
    }
}
