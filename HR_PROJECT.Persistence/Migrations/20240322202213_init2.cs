using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HR_PROJECT.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PermissionType", "RequestDate" },
                values: new object[] { "Baba İzni", new DateTime(2024, 3, 22, 23, 22, 13, 456, DateTimeKind.Local).AddTicks(6347) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "RequestDate",
                value: new DateTime(2024, 3, 22, 23, 22, 13, 456, DateTimeKind.Local).AddTicks(6379));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29eee336-e6a2-40f2-9305-159eed59ed75",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d996e46f-7fbb-4002-978f-06e0bfa7ac44", "AQAAAAIAAYagAAAAENRgedmO17My++DUGmZDKtX/iu0Yfe4b4veANOykg8MLHGSsSOF6lw9flrNZXopwCw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "df5a9b38-18e8-48b7-97bf-ad4a9b4afe0e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b64b6a29-72fb-47bc-967d-500fd8202a2d", "AQAAAAIAAYagAAAAEFp+7/GgKVeDbOulaLUlRGB+RO1GKDQwB0u9f3F86/17MZiJ2qK7PGj0TFWbm3KJnQ==" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PermissionType", "RequestDate" },
                values: new object[] { "Baba izni", new DateTime(2024, 3, 22, 23, 13, 16, 430, DateTimeKind.Local).AddTicks(9112) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "RequestDate",
                value: new DateTime(2024, 3, 22, 23, 13, 16, 430, DateTimeKind.Local).AddTicks(9134));
        }
    }
}
