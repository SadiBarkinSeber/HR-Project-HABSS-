using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HR_PROJECT.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class initAdvancePut : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.AddColumn<bool>(
                name: "IsCanceled",
                table: "Advances",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Advances",
                keyColumn: "Id",
                keyValue: 1,
                column: "IsCanceled",
                value: false);

            migrationBuilder.UpdateData(
                table: "Advances",
                keyColumn: "Id",
                keyValue: 2,
                column: "IsCanceled",
                value: false);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29eee336-e6a2-40f2-9305-159eed59ed75",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8090ffdb-c32d-45d8-b581-d5ae8105fa9a", "AQAAAAIAAYagAAAAENpVcisZX/nYrmI7Cf0i7yZtzcYuxf6PcppBYZsdiKfKJ0e2AgdO+d5qHEMZJY92Vg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "df5a9b38-18e8-48b7-97bf-ad4a9b4afe0e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9cdeda70-ded2-4ed8-b47b-01bab3e57b37", "AQAAAAIAAYagAAAAEMQwLDNxmKbq9wLS5ACzVWJ+9EUKUCO3kRd6OTNlounq2ZwuqFd4hG6ZusseGrli+A==" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsCanceled",
                table: "Advances");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29eee336-e6a2-40f2-9305-159eed59ed75",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "73a44bdd-c463-41bb-b3ed-4c2b5b62f7c5", "AQAAAAIAAYagAAAAENkkX5Js+ewQPTc4e6NmOyWl/aVh6wdgOAxwDkReapKIpXZLuKmcTM0D0h/oRyvpXQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "df5a9b38-18e8-48b7-97bf-ad4a9b4afe0e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4db16667-a1b6-45c4-afef-f263d9142aa1", "AQAAAAIAAYagAAAAEKLsKf462ms9lDekaU3QmPYMDDPb6TH0XslulgZjPhFNh6Zgk3LV97BRf4K/zghb8A==" });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "ApprovalStatus", "EmployeeId", "EndDate", "FileName", "IsApproved", "ManagerEmployeeId", "NumberOfDays", "PermissionType", "RequestDate", "StartDate" },
                values: new object[,]
                {
                    { 1, "Requested", 1, new DateTime(2024, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, 3, "Baba İzni", new DateTime(2024, 3, 22, 23, 22, 13, 456, DateTimeKind.Local).AddTicks(6347), new DateTime(2024, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "Requested", 1, new DateTime(2024, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, 4, "Anne izni", new DateTime(2024, 3, 22, 23, 22, 13, 456, DateTimeKind.Local).AddTicks(6379), new DateTime(2024, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }
    }
}
