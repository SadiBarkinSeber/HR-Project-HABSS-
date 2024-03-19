using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HR_PROJECT.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class initRoleOpes123 : Migration
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
                values: new object[] { "d99ccf5b-cb3e-4f4a-97df-393936372882", "AQAAAAIAAYagAAAAEFBtn6BwpuCNLG578Z1tYV2Qe41k8SnDa2e2ArGI8oN0YMphukoqKMgom+B5DBY5Mw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "df5a9b38-18e8-48b7-97bf-ad4a9b4afe0e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "00de0d80-4fc1-49ac-b73a-5e55dcebae3b", "AQAAAAIAAYagAAAAEFW0IEdUPO2XdxMUvuffKRI7M/n0xHrvTeUw4+M7PIac+r4ae67mRd+rrDnUhn5W3Q==" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "RequestDate",
                value: new DateTime(2024, 3, 19, 21, 30, 17, 663, DateTimeKind.Local).AddTicks(164));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "RequestDate",
                value: new DateTime(2024, 3, 19, 21, 30, 17, 663, DateTimeKind.Local).AddTicks(183));
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
                values: new object[] { "c7d1dec2-fdbd-48e6-ba70-313c8ba30082", "AQAAAAIAAYagAAAAEEfMJiROmYA8jeXEMBnEYeUqKd+15JKNYRHLASO70U1GFbrpqVXGpeGuGxfDL9Vojg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "df5a9b38-18e8-48b7-97bf-ad4a9b4afe0e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0d79b9d4-623c-420d-86a0-5bb5ad81c68c", "AQAAAAIAAYagAAAAEJ+o0VVdoXUNOjCnkZqWQJffZloxB7H+3YRcwth6/UxZFdPBc9n0ho8jcowmfQpBfg==" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "RequestDate",
                value: new DateTime(2024, 3, 19, 21, 22, 4, 233, DateTimeKind.Local).AddTicks(5250));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "RequestDate",
                value: new DateTime(2024, 3, 19, 21, 22, 4, 233, DateTimeKind.Local).AddTicks(6289));
        }
    }
}
