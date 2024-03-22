using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HR_PROJECT.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class initValdiaiton : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "AmountValue",
                table: "Advances",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AmountValue",
                table: "Advances");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "df5a9b38-18e8-48b7-97bf-ad4a9b4afe0e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ff75d0b1-1a47-40ed-b71e-0011c7dfde88", "AQAAAAIAAYagAAAAEMxBm/n5Iddf7j/PM7CZPiXRdNaO4Ybf1bbQv8/wOnQVtKwnBrX7eVw62mghyDQvHQ==" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "RequestDate",
                value: new DateTime(2024, 3, 17, 21, 18, 23, 198, DateTimeKind.Local).AddTicks(8943));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "RequestDate",
                value: new DateTime(2024, 3, 17, 21, 18, 23, 198, DateTimeKind.Local).AddTicks(8958));
        }
    }
}
