using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HR_PROJECT.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class initValdiaiton2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Advances",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "df5a9b38-18e8-48b7-97bf-ad4a9b4afe0e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e5d49df9-8cf5-4c55-bccb-fdaba1e29710", "AQAAAAIAAYagAAAAEFfie+O59zM9F90XfknCahEuNCZzt5koykWUKSj3IW8smJF6zfCmxbQE4Ncu3DKEzA==" });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Advances",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "df5a9b38-18e8-48b7-97bf-ad4a9b4afe0e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "522b8ba7-b182-44ad-ab6a-ba2dd3e6f95d", "AQAAAAIAAYagAAAAEM17dVFny88GVM/lDO3onDnrH5ypXfnVadVq4Q6bvfX7xhpJzwkjTULUW00y7xYrbw==" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "RequestDate",
                value: new DateTime(2024, 3, 22, 13, 12, 44, 487, DateTimeKind.Local).AddTicks(1410));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "RequestDate",
                value: new DateTime(2024, 3, 22, 13, 12, 44, 487, DateTimeKind.Local).AddTicks(1425));
        }
    }
}
